using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace Article.API
{
    internal static class HostingExtensions
    {
        public static WebApplication ConfigureServices(this WebApplicationBuilder builder)
        {
            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = "https://localhost:5001";
                    options.MetadataAddress = "https://localhost:5001/.well-known/openid-configuration";
                    //options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters.ValidateAudience = true;
                    options.TokenValidationParameters.ValidAudience = "article";
                    // it's recommended to check the type header to avoid "JWT confusion" attacks
                    options.TokenValidationParameters.ValidTypes = new[] { "at+jwt" };
                    //var jwtBearerSettings = builder.Configuration.GetSection(nameof(JwtBearerOptions)).Get<JwtBearerOptions>();
                    //options = jwtBearerSettings;
                });

            builder.Services.AddAuthorization(options =>
            {
                options.AddPolicy("Article Manager", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "article.write");
                    policy.RequireClaim("scope", "article.read");
                });

                options.AddPolicy("Article Consumer", policy =>
                {
                    policy.RequireAuthenticatedUser();
                    policy.RequireClaim("scope", "article.read");
                });
            });

            builder.Services.AddCors(options =>
            {
                // this defines a CORS policy called "default"
                options.AddPolicy("default", policy =>
                {
                    policy.WithOrigins(builder.Configuration["ClientUrl"])
                        .AllowAnyHeader()
                        .AllowAnyMethod();
                });
            });

            return builder.Build();
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseCors("default");

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();

            return app;
        }
    }
}
