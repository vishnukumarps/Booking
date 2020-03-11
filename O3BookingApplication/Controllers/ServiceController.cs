using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Maintenance.IRepository;
using Microsoft.AspNetCore.Mvc;
using O3BookingApp.DataModel;
using Maintenance.Repository;
using O3BookingApplication.Models;

namespace O3BookingApp.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IServiceRepository _service1;
        public ServiceController(IServiceRepository _service)
        {
            _service1 = _service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddService(Service service)
        {
            await _service1.Add(service);


            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult BookingForm()
        {

            return View();
        }

        [HttpPost]
        public IActionResult BookingForm(User user)
        {


            return View();
        }



    }
  }
