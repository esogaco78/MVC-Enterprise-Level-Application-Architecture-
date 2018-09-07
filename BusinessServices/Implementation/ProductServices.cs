using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities;
using BusinessServices.Interfaces;
using Common;

using AutoMapper;
using DataBase;
using Utilities;

namespace BusinessServices.Implementation
{
    public class ProductServices : IProductServices
    {
        private readonly UnitOfWork _unitOfWork;

        /// <summary>
        /// Public constructor.
        /// </summary>
        public ProductServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        /// Fetches all the products.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ProductEntity> GetAllProducts()
        {
            StringBuilder str = new StringBuilder("interview");
            var products = _unitOfWork.ProductRepository.GetAll().ToList();
            if (products.Any())
            {
                List<ProductEntity> dto = Mapper.Map<List<ProductEntity>>(products);
                return dto;
            }
            return null;
        }





    }
}
