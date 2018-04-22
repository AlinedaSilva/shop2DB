using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop2DB
{
    class Product
    {
        [Key]
        public int ProductID { get; set; }
        [Required(ErrorMessage ="Not Null")]
        public string Pname { get; set; }       
        public decimal Price { get; set; }
    }
}
