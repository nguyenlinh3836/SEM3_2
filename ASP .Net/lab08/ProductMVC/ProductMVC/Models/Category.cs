using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProductMVC.Models
{
    public class Category
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]     
        public int CategoryID { get; set; }
        public string title { get; set; }
        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}