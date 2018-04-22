using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop2DB
{
    class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        [Required(ErrorMessage ="Not Null")]
        public string CName { get; set; }
        public string CAddress { get; set; }
        public string Phone { get; set; }
    }
}
