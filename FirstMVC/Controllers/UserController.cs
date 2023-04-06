using FirstMVC.Extension;
using FirstMVC.FakeDB;
using FirstMVC.Models.DTO;
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
            ViewBag.id = id;
            UpdateUserDTO selectedUser = DB.users.Find(u => u.ID == id).ToUserDTO();
            return View(selectedUser);
        }

        [HttpPost]
        public IActionResult Update(int id, UpdateUserDTO update)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            _userService.Update(id, update);
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
