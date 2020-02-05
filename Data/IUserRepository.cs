using System.Threading.Tasks;
using hackAPI.Models;

namespace hackAPI.Data
{
    public interface IUserRepository
    {
        Task<User> Register(User user);
    }
}