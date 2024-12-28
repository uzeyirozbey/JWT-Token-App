using JwtAuthExampleApp.Models;
namespace JwtAuthExampleApp.Interfaces;

    public interface ITokenService
    {
        public Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest request);
    }


