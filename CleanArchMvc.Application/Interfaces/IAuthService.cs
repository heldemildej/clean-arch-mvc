using System.Threading.Tasks;

public interface IAuthService
{
    Task<string> Login(string username, string password);
}