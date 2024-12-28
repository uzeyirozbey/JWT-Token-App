using JwtAuthExampleApp.Interfaces;
using JwtAuthExampleApp.Models;
namespace JwtAuthExampleApp.Service;
public class AuthService : IAuthService
{
   readonly ITokenService tokenService;
    public AuthService(ITokenService tokenService)
    {
        this.tokenService = tokenService;
    }

    public async Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request)
    {
        UserLoginResponse response = new();
        //Burda kullanıcı bilgilerinin boş olma durumları kontrol ediliyor.
        if (string.IsNullOrEmpty(request.UserName) || string.IsNullOrEmpty(request.Password))
        {
            throw new ArgumentNullException(nameof(request));
        }
        //Bunu database bağlayacağız. Şimdilik statik.
        if (request.UserName == "ali_mirza" && request.Password == "123456789")
        {

            var generatedTokenInformation = await tokenService.GenerateToken(new GenerateTokenRequest { UserName = request.UserName });
             response.AuthenticateResult = true;
            response.AccessTokenExpireDate = generatedTokenInformation.TokenExpireDate;
            response.AuthToken = generatedTokenInformation.Token;
        }
        //return await Task.FromResult(response);
        return response;
    }
}