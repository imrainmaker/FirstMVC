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
            return View(DB.users);
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
            DB.users.Add(add.ToUser());
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            UpdateUserDTO selectedUser = DB.users.Find(u => u.ID == id).ToUserDTO();
            return View(selectedUser);
        }

        [HttpPost]
        public IActionResult Update(UpdateUserDTO update)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            //action
            DB.users[update.Id - 1].LastName = update.LastName;
            DB.users[update.Id - 1].FirstName = update.FirstName;
            DB.users[update.Id - 1].Email = update.Email;
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Read(int id)
        {
            User selectedUser = DB.users.Find(u => u.ID == id);
            return View(selectedUser);
        }
    }
}
