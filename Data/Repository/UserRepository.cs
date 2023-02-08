using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class UserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public List<User> GetAll()
        {
            return _context.users.ToList();
        }

        public void Add(User user)
        {
            _context.Add(user);
            _context.SaveChanges();
        }

    }
}
