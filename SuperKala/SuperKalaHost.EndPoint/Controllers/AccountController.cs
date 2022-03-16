using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SuperKala.Application.Dtos.ErrorValidation;
using SuperKala.Application.Dtos.UserAccount;
using SuperKala.Domain.UserAgg;

namespace SuperKalaHost.EndPoint.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        public AccountController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        public IActionResult Register(UserRegisterDto userRegisterDto)
        {
            #region Validation
            if (ModelState.IsValid == false)
            {
                return View("Register", userRegisterDto);
            }
            #endregion

            #region CreateUser
            var newUser = new User()
            {
                Email = userRegisterDto.Email,
                UserName = userRegisterDto.Email,
                PhoneNumber = userRegisterDto.PhoneNumber,
            };

            var result = _userManager.CreateAsync(newUser, userRegisterDto.Password).Result;
            #endregion

            #region ReturnFeedBack
            if (!result.Succeeded)
            {
                var messees = new List<ErrorValidation>();
                foreach (var item in result.Errors.ToList())
                {
                    messees.Add(new ErrorValidation()
                    {
                        Description = item.Description,
                    });
                }
                ViewBag.Messages = messees;
                return View(userRegisterDto);
            }

            #endregion

            return View();
        }
    }
}
