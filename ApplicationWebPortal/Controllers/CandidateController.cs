using ApplicationWebPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApplicationWebPortal.Controllers
{
    public class CandidateController : Controller
    {
        public IActionResult IndexCandidateStep1()
        {
            return View(new CandidateBasicInfo());
        }
    }
}
