
using Microsoft.Owin.Security.OAuth;
using OnlineStorePlatform.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace OnlineStorePlatform.Authentication_Middlware
{
    public class AuthenticationMiddleware : OAuthAuthorizationServerProvider
    {
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }

        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var user = User.login(context.UserName, context.Password);
            if (user == null)
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);
            identity.AddClaim(new Claim(ClaimTypes.Role, user.GetType().Name));
            identity.AddClaim(new Claim(ClaimTypes.Name, user.username));
            identity.AddClaim(new Claim("Email", user.email));
            context.Validated(identity);
        }
    }
}