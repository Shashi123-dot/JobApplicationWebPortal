using ApplicationWebPortal.Models;
using Microsoft.AspNetCore.Mvc;
using DL_JobApplicationWebPortal.DL_Model; // Ensure this namespace is correct for AppDbContext
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;
namespace ApplicationWebPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String userName, string password, string role)
        {
            if (role == "Candidate")
            {
                TempData["CandidateUsername"] = userName;
                return RedirectToAction("CandidateStep1", "Candidate");
            }

            // For Admin or HR, validate using DB  
            var user = _context.AdminDetails
               .FirstOrDefault(u => u.Username == userName && u.Password == password && u.Role == role);

            if (user == null)
            {
                ViewBag.Error = "Invalid credentials";
                return View("Index");
            }

            return RedirectToAction("AdminDashboard", "Admin");
        }
    }
}
