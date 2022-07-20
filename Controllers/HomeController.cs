using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PartyInvites.Models;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() 
        {
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()//применяется только для запросов get
        {
            return View();
        }
        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)//для запросов post
        {
            //Что сделать: сохранить ответ от гостя
            return View();
        }
    }
}
