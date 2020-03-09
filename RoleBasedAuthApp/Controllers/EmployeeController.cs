using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RoleBasedAuthApp.Controllers
{
    public class EmployeeController : Controller
    {
        [Authorize(Roles = "Admin, Manager, Employee")]
        public IActionResult Index()
        {
            return View();
        }
    }
}