using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSharpZip
{
    public class Product
    {
        public Product() { }

        [Range(minimum: 0.00, maximum: 10000.00)]
        public decimal Price { get; set; }
    }
}
