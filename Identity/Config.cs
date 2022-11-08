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

        public static IEnumerable<ApiScope> ApiScopes =>
            new List<ApiScope> {
                new ApiScope
                {
                    Name = "testscope",
                    DisplayName = "Test Scope",
                    Description = "Scope used for testing purposes"
                }
            };

        public static IEnumerable<Client> Clients =>
            new List<Client>
            {
                // React Client
                new Client
                {
                    ClientId = "react",
                    ClientName = "React Client",
                    AllowedGrantTypes = GrantTypes.Code,
                    RequireClientSecret = false,

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
                        "color"
                    }
                }
            };
    }
}