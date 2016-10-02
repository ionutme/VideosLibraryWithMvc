using System.Data.Entity;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Sticker.DataAccess;
using Sticker.DataAccess.Repositories;
using Sticker.Models.Factories;
using Sticker.Models.Factories.Mapping;
using Unity.Mvc5;

namespace Sticker
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            container.RegisterType<IUnitOfWork, UnitOfWork>();
            container.RegisterType<DbContext, StickerDb>();
            container.RegisterType<VideosRepository>();
            container.RegisterType<CommentsRepository>();
            
            container.RegisterType<VideoViewModelFactory>();
            container.RegisterType<VideoEntityFactory>();

            container.RegisterType<AutoMapper.IConfigurationProvider, AutoMapper.MapperConfiguration>();
            container.RegisterInstance(new MappingsConfig().Create());

            container.RegisterInstance(new UnitOfWork(new StickerDb()));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}