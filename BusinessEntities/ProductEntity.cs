using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities
{
   public class ProductEntity
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public int KitchenID { get; set; }
        public double price { get; set; }
    }
}
