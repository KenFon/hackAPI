using System.Threading.Tasks;
using hackAPI.Models;

namespace hackAPI.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;
        public UserRepository(DataContext context)
        {
            _context=context;
        }
        public async Task<User> Register(User user)
        {
            await _context.User.AddAsync(user);
            await _context.SaveChangesAsync();

            return user;
        }
    }
}