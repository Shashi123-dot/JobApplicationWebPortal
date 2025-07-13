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
        public IActionResult Login(string username, string password, string role)
        {
            if (role == "Admin" || role == "HR")
            {
                var user = _context.AdminDetails.FirstOrDefault(u =>
                    u.Username == username && u.Password == password && u.Role == role);

                if (user != null)
                {
                    return RedirectToAction("Dashboard", "Admin");
                }

                ViewBag.Error = $"Invalid {role} credentials";
                return View("Login");
            }

            if (role == "Candidate")
            {
                return RedirectToAction("CandidateStep1", "Candidate");
            }

            ViewBag.Error = "Invalid role selected.";
            return View("Login");
        }

    }
}
