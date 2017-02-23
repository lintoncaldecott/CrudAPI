using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using CrudAPI.DataLayer.DataAccess;
using CrudAPI.Controllers;
namespace CrudAPI
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            RegisterComponents();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<UserContext>();
        }
    }
}