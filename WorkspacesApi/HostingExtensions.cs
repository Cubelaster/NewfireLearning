using System.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Workspaces.Infrastructure;
using Workspaces.Infrastructure.EfContext;

namespace Workspaces.Api
{
    public static class HostingExtensions
    {
        public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
        {
            //builder.Services.AddCors();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            //builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //    .AddJwtBearer(options =>
            //    {
            //        //options.Authority = builder.Configuration["IdentityUrl"];
            //        //options.MetadataAddress = builder.Configuration["IdentityUrl"] + "/.well-known/openid-configuration";
            //        options.Authority = "https://localhost:6001";
            //        options.MetadataAddress = "https://localhost:6001/.well-known/openid-configuration";
            //        options.RequireHttpsMetadata = false;
            //        options.TokenValidationParameters.ValidateAudience = false;
            //    });

            //builder.Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Test Scope", policy =>
            //    {
            //        policy.RequireAuthenticatedUser();
            //        policy.RequireClaim("scope", "testscope");
            //    });
            //});

            //builder.Services.AddCors(options =>
            //{
            //    // this defines a CORS policy called "default"
            //    options.AddPolicy("default", policy =>
            //    {
            //        policy.WithOrigins(builder.Configuration["ReactAppUrl"])
            //            .AllowAnyHeader()
            //            .AllowAnyMethod();
            //    });
            //});

            builder.Services.AddInfrastructure(builder.Configuration);

            return builder;
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            //app.UseCors("default");

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllers();
            //.RequireAuthorization("Test Scope");

            return app;
        }
    }
}
