using CleanArchMvc.Domain.Entities;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User> GetByUsernameAsync(string username);
        Task AddAsync(User user);
    }
}