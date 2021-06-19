using System.Linq;
using System.Web.Mvc;
using Supercom.Models;

namespace Supercom.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            SupercomEntities entities = new SupercomEntities();
            var data = entities.GetUsers().ToList();
            ViewBag.userdetails = data;
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                //var userManagerService = new UsersManagerService.UserManagerService();
                //userManagerService.AddNewUser(user.ID, user.Name, 13);
                SupercomEntities db = new SupercomEntities();
                db.Users.Add(user);
                db.SaveChanges();
            }

            return View(user);
        }

        public ActionResult Create()
        { 
            return View();
        }
    }
}