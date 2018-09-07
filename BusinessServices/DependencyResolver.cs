using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Resolver;
using System.ComponentModel.Composition;
using BusinessServices;
using BusinessServices.Implementation;
using BusinessServices.Interfaces;

namespace BusinessServices
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            
            registerComponent.RegisterType<IProductServices, ProductServices>();
           

        }
    }
}
