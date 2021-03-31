using Autofac;
using Autofac.Integration.Mvc;
using System.Collections.Generic;
using System.Linq;
using Repositories.Interfaces;
using Repositories;
using System.Reflection;
using AppData;
using System.Web.Mvc;
using AppServices;
using AppServices.Mapper;
using AutoMapper;

namespace TheFirstSolution.App_Start
{
    public class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<TheFirstSolutionEntities>().AsSelf().InstancePerRequest();

            RegisterAutoMapper(builder);

            builder.RegisterAssemblyTypes(typeof(UserInfoService).Assembly)
                   .Where(t => t.Name.EndsWith("Service"))
                   .AsImplementedInterfaces()
                   .InstancePerRequest();

            builder.RegisterFilterProvider();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            return container;
        }

        private static void RegisterAutoMapper(ContainerBuilder builder)
        {
            builder.RegisterType<MappingProfile>().As<Profile>();
            builder.Register(c => new MapperConfiguration(cfg =>
            {
                foreach (var profile in c.Resolve<IEnumerable<Profile>>())
                {
                    cfg.AddProfile(profile);
                }
            })).AsSelf().SingleInstance();

            builder.Register(c => c.Resolve<MapperConfiguration>().CreateMapper(c.Resolve)).As<IMapper>().InstancePerLifetimeScope();
        }
    }
}