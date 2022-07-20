using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        public ViewResult RsvpForm()
        {
            return View();
        }
    }
}
