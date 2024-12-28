using JwtAuthExampleApp.Models;
namespace JwtAuthExampleApp.Interfaces;
public interface IAuthService
{
    public Task<UserLoginResponse> LoginUserAsync(UserLoginRequest request);
}

