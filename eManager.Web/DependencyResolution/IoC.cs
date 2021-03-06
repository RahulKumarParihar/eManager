using eManager.Domain;
using eManager.Web.Infrastructure;
using StructureMap;
namespace eManager.Web {
    public static class IoC {
        /// <summary>
        /// Initializes this instance.
        /// </summary>
        /// <returns></returns>
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
                            x.For<IDepartmentDataSource>().Use<DepartmentDb>();
                        });
            return ObjectFactory.Container;
        }
    }
}