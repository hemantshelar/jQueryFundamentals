using DAL.SQLDataProvider;
using PersonalDiary.Domain;
using StructureMap;
namespace jQueryFundamentalsUI {
    public static class IoC {
        public static IContainer Initialize() {
            ObjectFactory.Initialize(x =>
                        {
                            x.Scan(scan =>
                                    {
                                        scan.TheCallingAssembly();
                                        scan.WithDefaultConventions();
                                    });
            //                x.For<IExample>().Use<Example>();
                            x.For<IGenericUnitOfWork>().Use<SQLUnitOfWork>();
                            x.For<IGenericRepository<Address>>().Use <GenericRepositorySQLImpl<Address>>();
                            x.For<IGenericRepository<UserInfo>>().Use<GenericRepositorySQLImpl<UserInfo>>();
                            x.For<IGenericRepository<Reminder>>().Use<GenericRepositorySQLImpl<Reminder>>();
                            x.For<IGenericRepository<Notification>>().Use<GenericRepositorySQLImpl<Notification>>();
                        });
            return ObjectFactory.Container;
        }
    }
}