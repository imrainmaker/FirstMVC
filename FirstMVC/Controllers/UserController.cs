using FirstMVC.Extension;
using FirstMVC.FakeDB;
using FirstMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class UserController : Controller
    {




        public IActionResult Index()
        {
            return View(DB.AddUser());
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            return View();
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
            DB.AddUser(add.ToUser());
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Read(int id)
        {
            User selectedUser = DB.AddUser().Find(u => u.ID == id);
            return View(selectedUser);
        }
    }
}
