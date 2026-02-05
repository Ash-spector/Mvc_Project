using Mvc_Project.Data;
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
            var Students = context.Students.ToList();
            return View(Students);
        }
    }
}