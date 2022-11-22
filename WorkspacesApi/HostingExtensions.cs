using System.Globalization;
using System.Reflection;
using Core.Models.Utility.Configuration;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;
using Workspaces.Core;
using Workspaces.Infrastructure;

namespace Workspaces.Api
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
            builder.Services.AddCors(options =>
            {
                options.AddDefaultPolicy(policy =>
                {
                    policy
                        .WithOrigins(builder.Configuration.GetSection("CorsOrigin").Get<string[]>())
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials()
                        .SetIsOriginAllowedToAllowWildcardSubdomains();
                });
            });

            builder.Services.AddControllers();

            builder.Services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new HeaderApiVersionReader("Api-Version");
            });

            builder.Services.AddSignalR();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc(builder.Configuration.GetValue<string>("Swagger:Name"),
                    builder.Configuration.GetSection("Swagger:OpenApiOptions").Get<OpenApiInfo>());

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = @"JWT Authorization header using the Bearer scheme. \r\n\r\n 
                      Enter 'Bearer' [space] and then your token in the text input below.
                      \r\n\r\nExample: 'Bearer 12345abcdef'",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement()
                  {
                    {
                      new OpenApiSecurityScheme
                      {
                        Reference = new OpenApiReference
                          {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                          },
                          Scheme = "oauth2",
                          Name = "Bearer",
                          In = ParameterLocation.Header,

                        },
                        new List<string>()
                      }
                    });
            });

            builder
                .AddLocalization()
                .AddMiddleware();

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

            builder.Services
                .AddCore(builder.Configuration)
                .AddInfrastructure(builder.Configuration);

            return builder;
        }

        static WebApplicationBuilder AddLocalization(this WebApplicationBuilder builder)
        {
            builder.Services.AddLocalization();

            builder.Services.Configure<RequestLocalizationOptions>(
                options =>
                {
                    var supportedCultures = new List<CultureInfo>
                        {
                            new CultureInfo("hr-HR"),
                            new CultureInfo("sr-Latn"),
                            new CultureInfo("sr-Cyrl"),
                            new CultureInfo("en-US"),
                            new CultureInfo("de-DE"),
                            new CultureInfo("sl-SL"),
                            new CultureInfo("fr-FR"),
                            new CultureInfo("it-IT"),
                            new CultureInfo("mk-MK")
                        };

                    options.DefaultRequestCulture = new RequestCulture(culture: "hr-HR", uiCulture: "hr-HR");
                    options.SupportedCultures = supportedCultures;
                    options.SupportedUICultures = supportedCultures;
                    options.ApplyCurrentCultureToResponseHeaders = true;

                    // You can change which providers are configured to determine the culture for requests, or even add a custom
                    // provider with your own logic. The providers will be asked in order to provide a culture for each request,
                    // and the first to provide a non-null result that is in the configured supported cultures list will be used.
                    // By default, the following built-in providers are configured:
                    // - QueryStringRequestCultureProvider, sets culture via "culture" and "ui-culture" query string values, useful for testing
                    // - CookieRequestCultureProvider, sets culture via "ASPNET_CULTURE" cookie
                    // - AcceptLanguageHeaderRequestCultureProvider, sets culture via the "Accept-Language" request header
                    options.RequestCultureProviders.Insert(0, new AcceptLanguageHeaderRequestCultureProvider());
                });

            return builder;
        }

        static WebApplicationBuilder AddMiddleware(this WebApplicationBuilder builder)
        {
            return builder;
        }

        public static WebApplication ConfigurePipeline(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                var swaggerOptions = app.Configuration.GetSection("Swagger").Get<SwaggerSettings>();
                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(swaggerOptions.Endpoint, swaggerOptions.Name);
                });
            }

            app.UseRouting();
            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthentication();
            app.UseAuthorization();

            // app.Services.GetService<IOptions<RequestLocalizationOptions>>()!.Value
            app.UseRequestLocalization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            return app;
        }
    }
}
