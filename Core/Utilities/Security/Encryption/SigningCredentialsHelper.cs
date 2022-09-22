using Microsoft.IdentityModel.Tokens;

namespace Core.Utilities.Security.Encryption
{
    public partial class SecurityKeyHelper
    {
        public class SigningCredentialsHelper
        {
            public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
            {
                //Credentials bir siteme girmek için elimizde olanlardır.Kullanıcı adı ve parolamızdır.
                return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);

            }
        }

    }
}
