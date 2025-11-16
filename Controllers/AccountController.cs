
 
using Project2d.Models;
using System.Linq;
 using System.Web.Mvc;

namespace Project1.Controllers
{
    public class AccountController : Controller
    {


        private VistaraDb2Entities1 d = new VistaraDb2Entities1();

        // GET: Login
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(LoginModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            if (model.Role == "Employee")
            {

                var emp = d.EmployeeLogins
                            .FirstOrDefault(e => e.UserName == model.Username && e.Password == model.Password);

                if (emp != null)
                {
                    Session["Username"] = emp.UserName;
                    Session["Role"] = "Employee";
                    return RedirectToAction("Emphome", "Emp");
                }
                ViewBag.Error = "Invalid employee username or password.";
                return View(model);
            }
            else if (model.Role == "Manager")
            {
                var mgr = d.ManagerLogins
                            .FirstOrDefault(m => m.UserName == model.Username && m.Password == model.Password);

                if (mgr != null)
                {
                    Session["Username"] = mgr.UserName;
                    Session["Role"] = "Manager";
                    return RedirectToAction("Managerhome", "Manager");
                }
                ViewBag.Error = "Invalid manager username or password.";
                return View(model);
            }

            ViewBag.Error = "Please select a role.";
            return View(model);
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

         



    }
}
