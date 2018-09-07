using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities;
using DataBase;

namespace Utilities
{
    public class AutoMapperUtil
    {
       

        public static void InitializeMapper()
        {
            

            Mapper.Initialize(cfg =>
            {
               cfg.CreateMap<tblProduct, ProductEntity>().ReverseMap();
               
               
            });
        }
    }
}
