using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMVC.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string name { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public double Price { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}