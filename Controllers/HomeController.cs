using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using form_submission.Models;

namespace form_submission.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Index()
        {
            return View();
        }
        [HttpPost("Submit")]
        public IActionResult Submit(User submittedForm)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Result", submittedForm);
            }
            else
            {
                return View("Index");
            }
        }
        [HttpGet("result")]
        public ViewResult Result(User submittedForm)
        {
            return View(submittedForm);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
