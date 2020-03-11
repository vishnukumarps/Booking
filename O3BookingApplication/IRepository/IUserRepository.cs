using O3BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApplication.IRepository
{
     public  interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        //Task<Service> Get(string id);
        Task Add(User user);

    }
}
