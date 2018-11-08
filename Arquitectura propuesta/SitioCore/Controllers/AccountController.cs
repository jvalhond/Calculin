using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RepositorioCore;
using SitioCore.Data;
using SitioCore.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SitioCore.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRepositorio _repositorio;
        private readonly UserManager<UsuarioConversor> userManager;
        private readonly SignInManager<UsuarioConversor> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<UsuarioConversor> userManager, SignInManager<UsuarioConversor> signInManager, RoleManager<IdentityRole> roleManager, IRepositorio repositorio)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
            _repositorio = repositorio;
        }

        [HttpGet]
        public IActionResult RegistroUsuario()
        {
            var listaPaises = _repositorio.ObtenerPaises();
            var registroUsuarioViewModel = new RegistroUsuarioViewModel {ListaPaises = listaPaises };
            return View(registroUsuarioViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> RegistroUsuario(RegistroUsuarioViewModel model)
        {

            if (!ModelState.IsValid)
                return View("Error");

            var user = new UsuarioConversor() { UserName = model.Email, Email = model.Email, FechaNacimiento = model.FechaNacimiento, Pais = model.IdPais };
            var result = await userManager.CreateAsync(
                user, model.Password);

            if (result.Succeeded)
            {
                return View("RegistrationConfirmation");
            }

            foreach (var error in result.Errors)
                ModelState.AddModelError("error", error.Description);
            return View(model);
        }

        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var result =
                    await
                        signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe,
                            lockoutOnFailure: false);
                if (result.Succeeded)
                    return RedirectToLocal(returnUrl);
                if (result.RequiresTwoFactor)
                {
                    //
                }
                if (result.IsLockedOut)
                {
                    return View("Lockout");
                }

                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(model);

            }
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> LogOff()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
    }
}
