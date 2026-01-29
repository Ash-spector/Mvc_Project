using Mvc_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Project.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult index()
        {
            Employee employee = new Employee();
            employee.Empno = 101;
            employee.Name = "Aniket shukla";
            employee.Address = "GBS";
            employee.Salary = 1000;

            Employee employee1 = new Employee();
            employee.Empno = 102;
            employee.Name = "Abhay sharma";
            employee.Address = "Baddu";
            employee.Salary = 999;


            //Employee employee = new Employee { Empno = 101 ,Name = "Aarav", Address = "GBS", Salary = 1000};
            //Employee emp = new Employee()
            //{
            //    Empno = 101,
            //    Name = "John Doe",
            //    Address = "123 Main St",
            //    Salary = 50000
            //};

            // Employee employee = new Employee { Empno = 102, Name = "Aniket", Address = " GBS socity", Salary = 55000 };
            return View(employee);
        }
    }
}