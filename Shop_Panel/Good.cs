using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Panel
{
    public class Good
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        public int? CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
