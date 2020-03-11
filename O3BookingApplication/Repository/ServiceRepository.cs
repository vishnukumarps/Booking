using Maintenance.DbModels;
using Maintenance.IRepository;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using O3BookingApp.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using O3BookingApplication.Models;

namespace Maintenance.Repository
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly ObjectContext _context = null;

        
        public ServiceRepository(IOptions<Settings> settings)
        {
            _context = new ObjectContext(settings);
        }

        public async Task Add(Service service)
        {

            try
            {
                await _context.Services.InsertOneAsync(service);
            }
            catch (Exception ex)
            { }


     

        }

       
      
        async Task<IEnumerable<Service>> IServiceRepository.GetAll()
        {
            return await _context.Services.Find(x => true).ToListAsync();
        }

        async Task<Service> IServiceRepository.Get(string id)
        {
            var service = Builders<Service>.Filter.Eq("Id", id);
            return await _context.Services.Find(service).FirstOrDefaultAsync();

            throw new NotImplementedException();
        }
    }
}
