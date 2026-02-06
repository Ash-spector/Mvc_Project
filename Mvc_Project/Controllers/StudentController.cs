using Mvc_Project.Data;
using Mvc_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Project.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationDbcontext context;

        public StudentController()
        {
            context = new ApplicationDbcontext();
        }

        // GET: Student
        public ActionResult Index()
        {
            var students = context.Students.ToList();
            return View(students);
        }

        [ActionName("Update-insert")]
        public ActionResult Upsert(int? id)
        {
            var student = new Student();

            if (id == null)
            {
                return View(student);
            }

            student = context.Students.Find(id.Value);

            if (student == null)
            {
                return HttpNotFound();
            }

            return View(student);
        }
    }
}
