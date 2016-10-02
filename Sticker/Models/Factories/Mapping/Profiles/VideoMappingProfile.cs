using AutoMapper;
using Sticker.DataAccess.Entities;
using Sticker.Models.Factories.Resolvers;

namespace Sticker.Models.Factories.Mapping.Profiles
{
    public class VideoMappingProfile : Profile
    {
        public VideoMappingProfile()
        {
            CreateMap<Video, VideoViewModel>();
            CreateMap<VideoViewModel, Video>().ForMember(v => v.Link, f => f.ResolveUsing<LinkResolver>());
        }
    }
}