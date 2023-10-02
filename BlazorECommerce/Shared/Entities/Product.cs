using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorECommerce.Shared.Entities
{
    public class Product:BaseEntity<int>
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty ;
        public string Image { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public decimal PriceTotal { get; set; }
        public double Tax { get; set; }
        public string Code { get; set; }= string.Empty;
        public bool Status { get; set; }

    }
}
