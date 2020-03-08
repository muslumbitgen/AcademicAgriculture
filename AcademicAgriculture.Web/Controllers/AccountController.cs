using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AcademicAgriculture.Web.Entities;
using AcademicAgriculture.Web.Models.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AcademicAgriculture.Web.Controllers
{
    [AutoValidateAntiforgeryToken]
    public class AccountController : Controller
    {
        private CustomIdentityDbContext _customIdentityDbContext;
        private UserManager<CustomIdentityUser> _userManager;
        private RoleManager<CustomIdentityRole> _roleManager;
        private SignInManager<CustomIdentityUser> _signInManager;
        private IPasswordHasher<CustomIdentityUser> _passwordHasher;
        public AccountController(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager, CustomIdentityDbContext customIdentityDbContext, IPasswordHasher<CustomIdentityUser> passwordHasher)
        {
            _passwordHasher = passwordHasher;
            _customIdentityDbContext = customIdentityDbContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var userListViewModel = new UserListViewModel
            {
                Users = _customIdentityDbContext.Users.ToList()
            };
            return View(userListViewModel);
        }
        [Authorize(Roles = "Admin")]
        public ActionResult Register()
        {
            return View(new RegisterViewModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                CustomIdentityUser user = new CustomIdentityUser
                {
                    FullName = registerViewModel.FullName,
                    UserName = registerViewModel.UserName,
                    Email = registerViewModel.Email,
                    RolName = "Admin",
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                };

                IdentityResult result =
                    _userManager.CreateAsync(user, registerViewModel.Password).Result;
                if (result.Succeeded)
                {
                    if (!_roleManager.RoleExistsAsync("Admin").Result)
                    {
                        CustomIdentityRole role = new CustomIdentityRole
                        {
                            Name = "Admin"
                        };

                        IdentityResult roleResult = _roleManager.CreateAsync(role).Result;

                        if (!roleResult.Succeeded)
                        {
                            ModelState.AddModelError("", "We can't add the role!");
                            return View(registerViewModel);
                        }
                    }

                    _userManager.AddToRoleAsync(user, "Admin").Wait();
                    return RedirectToAction("Index", "Account");
                }
            }

            return View(registerViewModel);
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(string id)
        {
            CustomIdentityUser user = await _userManager.FindByIdAsync(id);
            if (user != null)
            {
                var model = new UserUpdateViewModel
                {
                    FullName = user.FullName,
                    UserName = user.UserName,
                    Email = user.Email,
                };
                return View(model);
            }
            else
                return RedirectToAction("Index");
        }
        [HttpPost]
        public async Task<IActionResult> Update(UserUpdateViewModel user, string id)
        {
            CustomIdentityUser newUser = await _userManager.FindByIdAsync(id);
            if (newUser != null)
            {
                if (!string.IsNullOrEmpty(user.Email))
                    newUser.Email = user.Email;
                else
                    ModelState.AddModelError("", "Email boş olamaz");

                if (!string.IsNullOrEmpty(user.Password))
                    newUser.PasswordHash = _passwordHasher.HashPassword(newUser, user.Password);
                else
                    ModelState.AddModelError("", "Şifre boş olamaz");

                if (!string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.Password))
                {
                    newUser.FullName = user.FullName;
                    newUser.UserName = user.UserName;
                    newUser.RolName = "Admin";
                    newUser.UpdateDate = DateTime.Now;
                    IdentityResult result = await _userManager.UpdateAsync(newUser);
                    if (result.Succeeded)
                        return RedirectToAction("Index");
                    else
                        Errors(result);
                }
            }
            else
                ModelState.AddModelError("", "Kullanıcı Bulunamadı.");
            return View(newUser);
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }
            var user = await _userManager.FindByNameAsync(loginViewModel.UserName);
            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı Bulunamadı!");
                return View(loginViewModel);
            }
            var result = await _signInManager.PasswordSignInAsync(loginViewModel.UserName,
                loginViewModel.Password, loginViewModel.RememberMe, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Admin");
            }
            ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Yanlış!");
            return View(loginViewModel);
        }

        [IgnoreAntiforgeryToken]
        public async Task<IActionResult> Delete(string Id)
        {
            CustomIdentityUser user = await _userManager.FindByIdAsync(Id);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                else
                    Errors(result);
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı Bulunamadı");
            }
            var userListViewModel = new UserListViewModel
            {
                Users = _customIdentityDbContext.Users.ToList(),
            };
            return View("Index", userListViewModel);
        }
        private void Errors(IdentityResult result)
        {
            foreach (IdentityError error in result.Errors)
                ModelState.AddModelError("", error.Description);
        }

        public ActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("Login");
        }
        public ActionResult AccessDenied()
        {
            return View();
        }
    }
}