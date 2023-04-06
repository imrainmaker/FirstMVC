using FirstMVC.FakeDB;
using FirstMVC.Models;
using FirstMVC.Models.DTO;
using FirstMVC.Models.Mapper;
using FirstMVC.Service.Interfaces;
using FirstMVC.Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class UserController : Controller
    {

        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return View(_userService.Get());
        }

        public IActionResult Read(int id)
        {
            return View(_userService.GetById(id));
        }

        public IActionResult Delete(int id)
        {
            if (_userService.Delete(id))
            {
                return RedirectToAction("Index");
            }
            return View("NotFound");
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddUserDTO add)
        {
            if (!ModelState.IsValid)
            {
                return View();

            }
            _userService.CreateUser(add);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            User user = _userService.GetById(id);
            ViewBag.id = id;

            return View(user.ToUserDTO());
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateUserDTO user)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _userService.Update(id, user);
            return RedirectToAction("Index");
        }

        public IActionResult UpdatePassword(int id)
        {
            User user = _userService.GetById(id);
            ViewBag.id = id;
            return View();
           
        }

        [HttpPost]
        public IActionResult UpdatePassword(int id, UpdateUserPasswordDTO mdp)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_userService.UpdatePassword(id, mdp) is null)
            {
                ModelState.AddModelError("Password", "Le mot de passe ne correspond pas au mot de passe actuel");
                return View();
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

    }
}
