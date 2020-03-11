using Microsoft.AspNetCore.Mvc;
using O3BookingApplication.IRepository;
using O3BookingApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApplication.Controllers
{
    public class UsersController: Controller
    {
        private readonly IUserRepository _service1;
        public UsersController(IUserRepository _service)
        {
            _service1 =_service;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> BookingForm(User user)
        {
            await _service1.Add(user);

            return RedirectToAction("Index");
        }
    }
}
