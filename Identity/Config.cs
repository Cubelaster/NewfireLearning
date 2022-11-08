using System;
using Duende.IdentityServer;
using Duende.IdentityServer.Models;
using IdentityModel;

namespace Identity
{
    public static class Config
    {
        public static IEnumerable<IdentityResource> IdentityResources =>
            new IdentityResource[]
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile(),
                new IdentityResources.Email(),
                new IdentityResource
                {
                    Name = "verification",
                    DisplayName = "Verification",
                    Description = "Claims used for verification",
                    UserClaims = new List<string>
                    {
                        JwtClaimTypes.Email,
                        JwtClaimTypes.EmailVerified
                    }
                },
                new IdentityResource("color", new [] { "favorite_color" })
            };

        // Specific scopes that could be linked to actions 1:1
        // Standard Claims
        public static IEnumerable<ApiScope> ApiScopes => new List<ApiScope>
        {
            new ApiScope(name: "testscope", displayName: "Test Scope")
            {
                Description = "Scope used for testing purposes"
            },
            // invoice API specific scopes
            new ApiScope(name: "invoice.read",   displayName: "Reads your invoices."),
            new ApiScope(name: "invoice.pay",    displayName: "Pays your invoices."),

            // customer API specific scopes
            new ApiScope(name: "customer.read",    displayName: "Reads you customers information."),
            new ApiScope(name: "customer.contact", displayName: "Allows contacting one of your customers."),

            new ApiScope(name: "article.read",   displayName: "Reads your articles."),
            new ApiScope(name: "article.write",   displayName: "Modifies your articles."),

            // shared scope
            new ApiScope(name: "manage", displayName: "Provides administrative access to invoice and customer data.")
        };

        // Api Resources group EXISTING ApiScopes and provide an aud claim for the token
        // This means that if the client tries to request any scope that is contained in a resource
        // It gets ALL of the scopes from a resource back and additionally gets aud filled with the resource name
        public static IEnumerable<ApiResource> ApiResources => new List<ApiResource>
        {
            new ApiResource("invoice", "Invoice API")
            {
                Scopes = { "invoice.read", "invoice.pay", "manage" }
            },
            new ApiResource("customer", "Customer API")
            {
                Scopes = { "customer.read", "customer.contact", "manage" }
            },
            new ApiResource("article", "Article API")
            {
                Scopes = { "article.read", "article.write" }
            }
        };

        public static IEnumerable<Client> Clients => new List<Client>
        {
            // machine to machine client
            new Client
            {
                ClientId = "Machine",

                // no interactive user, use the clientid/secret for authentication
                AllowedGrantTypes = GrantTypes.ClientCredentials,

                // secret for authentication
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                // scopes that client has access to
                AllowedScopes = { "testscope" }
            },

            // React Client
            new Client
            {
                ClientId = "react",
                ClientName = "React Client",
                AllowedGrantTypes = GrantTypes.Code,

                // secret for authentication
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                RedirectUris =           { "https://localhost:5005/callback" },
                PostLogoutRedirectUris = { "https://localhost:5005/" },
                AllowedCorsOrigins =     { "https://localhost:5005" },

                AllowedScopes = new List<string>
                {
                    IdentityServerConstants.StandardScopes.OpenId,
                    IdentityServerConstants.StandardScopes.Profile,
                    IdentityServerConstants.StandardScopes.Email,
                    "verification",
                    "testscope",
                    // Specific scopes that are a part of resources
                    "article.read",
                    "article.write"
                }
            }
        };
    }
}