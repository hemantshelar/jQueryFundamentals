using System.Web.Mvc;
using StructureMap;

[assembly: WebActivator.PreApplicationStartMethod(typeof(jQueryFundamentalsUI.App_Start.StructuremapMvc), "Start")]

namespace jQueryFundamentalsUI.App_Start {
    public static class StructuremapMvc {
        public static void Start() {
            var container = (IContainer) IoC.Initialize();
            DependencyResolver.SetResolver(new SmDependencyResolver(container));
        }
    }
}