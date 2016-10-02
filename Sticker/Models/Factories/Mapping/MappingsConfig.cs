using AutoMapper;
using Sticker.Models.Factories.Mapping.Profiles;

namespace Sticker.Models.Factories.Mapping
{
    public class MappingsConfig
    {
        public MapperConfiguration Create()
        {
            return new MapperConfiguration(cfg => cfg.AddProfiles(new[] {typeof(VideoMappingProfile)}));
        }
    }
}