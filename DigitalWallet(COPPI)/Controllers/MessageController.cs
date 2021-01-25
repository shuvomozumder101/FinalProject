using DigitalWallet_COPPI_.Data;
using DigitalWallet_COPPI_.Models.Message;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalWallet_COPPI_.Controllers
{
    public class MessageController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public MessageController(IHttpContextAccessor httpContextAccessor, UserManager<IdentityUser> userManager ,AppDbContext appDbContext)
        {
            _context = appDbContext;
            _userManager = userManager;
            _httpContextAccessor = httpContextAccessor;

        }
        public IActionResult Messages()
        {
            var model = new Message();
            var user = _userManager.GetUserAsync(HttpContext.User);
            ViewBag.UserName = "name";
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Messages([Bind(
                                        nameof(Message.UserId),
                                        nameof(Message.userInput),
                                        nameof(Message.messageInput)
                                       )] Message message)
        {
            if (ModelState.IsValid)
            {
                _context.Add(message);
                _context.SaveChanges();
            }
            return View();
        }
    }
}
