using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace DataManager.Base;

public class AuthOptions
{
    public const string ISSUER = "MyAuthServer";
    public const string AUDIENCE = "MyAuthClient";
    const string KEY = "mysupersecret_secretkey!123";
    public const int LIFETIME = 30;
    public static SymmetricSecurityKey GetSymmetricSecurityKey()
    {
        return new SymmetricSecurityKey(Encoding.ASCII.GetBytes(KEY));
    }
    public string? access_token { get; set; }
    public string? role { get; set; }
    public string? username { get; set; }
    public int? Id { get; set; }
}