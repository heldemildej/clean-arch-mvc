using CleanArchMvc.Domain.Interfaces;
using CleanArchMvc.Application.Interfaces;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;

        public AuthService(IUserRepository userRepository, ITokenService tokenService)
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<string> Login(string username, string password)
        {
            var user = await _userRepository.GetByUsernameAsync(username);

            if (user == null)
                return null;

            var valid = BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);

            if (!valid)
                return null;

            return _tokenService.GenerateToken(user.Id, user.Username, user.Role);
        }
    }
}