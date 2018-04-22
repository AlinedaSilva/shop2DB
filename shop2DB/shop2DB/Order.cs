using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace shop2DB
{
    class Order
    {
        [Key]
        public int OrderID { get; set; }

        public int ProductID { get; set; }
        public int CustomerID { get; set; }
        public int Qty { get; set; }

    }
}
