using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Linq;
using System.Web;

namespace ProductMVC.Models
{
    public class Enrollment
    {        
            public int EnrollmentID { get; set; }
            public int ProductId { get; set; }

            public int CategoryID { get; set; }

            public virtual Product Product { get; set; }
            public virtual Category Category { get; set; }
        }    
}