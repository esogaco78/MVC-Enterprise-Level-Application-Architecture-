using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;

namespace BusinessServices.Interfaces
{
    public interface IProductServices
    {
        IEnumerable<ProductEntity> GetAllProducts();
    }
}
