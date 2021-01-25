using DigitalWallet_COPPI_.Models.Profile;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Controllers
{
    public class ProfileController : Controller
    {
       
        public IActionResult Profile()
        {
            var model = new ProfileModel();
            return View(model);
        }
        public IActionResult EditProfile()
        {
            var model = new ProfileModel();
            return View(model);
        }
        public IActionResult Friends()
        {
            var model = new FriendsModel();
            return View(model);
        }
        public IActionResult About()
        {
            var model = new AboutModel();
            return View(model);
        }
    }
}
