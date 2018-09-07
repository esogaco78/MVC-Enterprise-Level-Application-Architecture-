using System.ComponentModel.Composition;
using System.Data.Entity;
using Resolver;
using DataBase;


namespace DataBase
{
    [Export(typeof(IComponent))]
    public class DependencyResolver : IComponent
    {
        public void SetUp(IRegisterComponent registerComponent)
        {
            registerComponent.RegisterType<IUnitOfWork, UnitOfWork>();
        }
    }
}
