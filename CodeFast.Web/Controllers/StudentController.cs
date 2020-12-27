using CodeFast.Web.Manager.Interface;
using CodeFast.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CodeFast.Web.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentManager _studentManager;

        public StudentController(IStudentManager studentManager)
        {
            _studentManager = studentManager;
        }
        public IActionResult Index()
        {
            var model = _studentManager.GetStudents().ToList();
            return View(model);
        }
        public ActionResult Edit(int id = 0)
        {
            Student model = _studentManager.GetStudentById(id);
            return PartialView(model);
        }         

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Student model)
        {
            //Validate Student  
            if (ModelState.IsValid)
            {
                var update = _studentManager.Update(model);
                if (update != null)
                {
                    ViewBag.Success = "Successfully updated";
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Create()
        {
            return PartialView();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Student model)
        {
            if (!ModelState.IsValid)
            {
                var create = _studentManager.Create(model);
                if (create != null)
                {
                    ViewBag.Success = "Successfully updated";
                }
            }
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id = 0)
        {
            Student model = _studentManager.GetStudentById(id);
            return PartialView(model);
        }
    }
}
