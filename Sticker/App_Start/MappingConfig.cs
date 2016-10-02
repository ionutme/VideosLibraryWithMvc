using System.Reflection;
using AutoMapper;
using Sticker.Extensions;

namespace Sticker
{
    public class MappingConfig
    {
        public MapperConfiguration Create()
        {
            return new MapperConfiguration(cfg => cfg.AddProfiles(GetCurrentAssembly().AsCollection()));
        }

        private Assembly GetCurrentAssembly()
        {
            return GetType().Assembly;
        }
    }
}