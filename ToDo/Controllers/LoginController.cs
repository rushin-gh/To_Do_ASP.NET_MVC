using System.Web.Mvc;
using ToDo.Business;

namespace ToDo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Models.ToDoModel model)
        {
            int userId = DB.GetUserId(model);
            return View(model);
        }
    }
}