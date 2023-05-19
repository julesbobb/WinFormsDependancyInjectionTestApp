using CSharp.Forms.Data;
using CSharp.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using User = CSharp.Forms.Data.Models.User;

namespace CSharp.Repository.Services
{
    public class UsersRepository : IUsersRepository
    {
        private readonly DataContext _dataContext;

        public UsersRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Add(User user)
        {
            _dataContext.Add(user);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Delete(User user)
        {
            var _user = await _dataContext.Users.FindAsync(user.Id);
            if (_user != null)
            {
                _dataContext.Remove(_user);
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<User> Get(string username)
        {
            return await _dataContext.Users.Where(x => x.Name == username).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _dataContext.Users.ToListAsync();
        }

        public async Task Update(User user)
        {
            var _user = await _dataContext.Users.FindAsync(user.Id);
            if (_user != null)
            {
                _user.Name = user.Name;
                await _dataContext.SaveChangesAsync();
            }
        }

        public async Task<bool> UserExists(string username)
        {
            return await _dataContext.Users.Where(x => x.Name == username).AnyAsync();
        }

    }
}
