using Mvc_Project.Data;
using Mvc_Project.Models;
using System.Linq;
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

        [ActionName("Upsert")]
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Upsert(Student student)
        {
            // edit ka liye id check krna hoga
            if (student == null) return HttpNotFound();

            // Validate model
            if (!ModelState.IsValid) return View(student);

            // Check duplicate email (ignore current record when updating)
            var duplicateEmail = context.Students
                .FirstOrDefault(s => s.Email == student.Email && s.Id != student.Id);

            if (duplicateEmail != null)
            {
                ModelState.AddModelError("Email", "Email already exists.");
                return View(student);
            }

            if (student.Id == 0)
            {
                context.Students.Add(student);
            }
            else
            {
                var studentInDb = context.Students.Find(student.Id);
                if (studentInDb == null) return HttpNotFound();

                studentInDb.Name = student.Name;
                studentInDb.Age = student.Age;
                studentInDb.Address = student.Address;
                studentInDb.Email = student.Email;
            }

            context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
