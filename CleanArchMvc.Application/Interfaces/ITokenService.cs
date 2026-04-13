namespace CleanArchMvc.Application.Interfaces
{
    public interface ITokenService
    {
        string GenerateToken(int userId, string username, string role);
    }
}