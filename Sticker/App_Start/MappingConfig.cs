using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Sticker.DataAccess.Entities;
using Sticker.Models;
using Sticker.Models.Factories;
using Sticker.Models.Factories.Resolvers;

namespace Sticker
{
    public class MappingConfig
    {
        public static void RegisterFactories()
        {
            //var config = new MapperConfiguration(cfg => cfg.AddProfiles(new[] {typeof(VideoMappingProfile)}));
            //IMapper mapper = config.CreateMapper();

            Mapper.Initialize(cfg => cfg.AddProfiles(new[] {typeof(VideoMappingProfile)}));
        }
    }

    public class VideoMappingProfile : Profile
    {
        public VideoMappingProfile()
        {
            CreateMap<Video, VideoViewModel>();
            CreateMap<VideoViewModel, Video>().ForMember(v => v.Link, f => f.ResolveUsing<LinkResolver>());
        }
    }
}