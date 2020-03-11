
using O3BookingApp.DataModel;
using O3BookingApplication.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Maintenance.IRepository
{
    public interface IServiceRepository
    {
        Task<IEnumerable<Service>>GetAll();
        Task<Service> Get(string id);
        Task Add(Service service);
       
        

    }
}
