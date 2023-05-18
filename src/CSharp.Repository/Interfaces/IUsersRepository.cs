using CSharp.Forms.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Repository.Interfaces
{
    public interface IUsersRepository
    {

        Task<IEnumerable<User>> GetAll();
        Task<User> Get(string username);
        Task Update(User user);
        Task Delete(User user);
        Task Add(User user);
        Task<bool> UserExists(string username);
    }
}
