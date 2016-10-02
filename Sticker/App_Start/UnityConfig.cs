using System.Data.Entity;
using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Sticker.DataAccess;
using Sticker.DataAccess.Repositories;
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

            container.RegisterInstance(new UnitOfWork(new StickerDb()));

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}