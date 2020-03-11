using Maintenance.DbModels;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using O3BookingApplication.IRepository;
using O3BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApplication.Repository
{
    public class UserRepository:IUserRepository
    {
        private readonly ObjectContext _context = null;


        public UserRepository(IOptions<Settings> settings)
        {
            _context = new ObjectContext(settings);
        }

        public async Task Add(User user)
        {
            int id = 0;
            var result = _context.Users.Find(FilterDefinition<User>.Empty).ToList();
            foreach (User item in result)
            {
                if (id < item.SerailNo)
                {
                    id = item.SerailNo;
                }
            }
            List<User> userList = new List<User>();
            user.SerailNo = id + 1;

            await _context.Users.InsertOneAsync(user);
            
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _context.Users.Find(x => true).ToListAsync();
        }
    }
}
