﻿using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Cards.Infrastructure;
using MediatR;
using Cards.Infrastructure.EfContext;
using Microsoft.EntityFrameworkCore;

namespace Cards.Api
{
    public static class HostingExtensions
    {
        public static WebApplicationBuilder BuildEnvironment(this WebApplicationBuilder builder, string[] args)
        {
            var env = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? Environments.Production;
            builder.Configuration
                .AddCommandLine(args)
                .AddJsonFile($"appsettings.json")
                .AddJsonFile($"appsettings.{env}.json")
                .AddEnvironmentVariables();

            if (env != Environments.Production)
            {
                // This part here is required when Migrations are NOT in the same project as UserSecrets
                // For whatever reason, it won't work then
                builder.Configuration.AddUserSecrets(assembly: Assembly.GetExecutingAssembly());
            }

            return builder;
        }

        public static WebApplicationBuilder ConfigureServices(this WebApplicationBuilder builder)
        {
            builder.Services.AddCors();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.Authority = builder.Configuration["IdentityUrl"];
                    options.MetadataAddress = builder.Configuration["IdentityUrl"] + "/.well-known/openid-configuration";
                    options.RequireHttpsMetadata = false;
                    options.TokenValidationParameters.ValidateAudience = false;
                });

            //builder.Services.AddAuthorization(options =>
            //{
            //    options.AddPolicy("Test Scope", policy =>
            //    {
            //        policy.RequireAuthenticatedUser();
            //        policy.RequireClaim("scope", "testscope");
            //    });
            //});

            builder.Services.AddCors(options =>
            {
                // this defines a CORS policy called "default"
                options.AddDefaultPolicy(policy =>
                {
                    policy.AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowedToAllowWildcardSubdomains();
                });
            });

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

            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });


            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;

                var context = services.GetRequiredService<CardsContext>();
                if (context.Database.GetPendingMigrations().Any())
                {
                    context.Database.Migrate();
                }
            }

            return app;
        }
    }
}