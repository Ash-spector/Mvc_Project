using Mvc_Project.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Mvc_Project.Data
{
    public class ApplicationDbcontext :DbContext 
    {
        public ApplicationDbcontext():base("Constr")
        {

        }
        public DbSet <Student> Students { get; set; }
    }
}