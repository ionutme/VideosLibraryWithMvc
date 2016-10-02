using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Sticker.DataAccess.Entities;
using Sticker.Models;

namespace Sticker
{
    public class MappingConfig
    {
        public static void RegisterFactories()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfiles(new[] {typeof(OrganizationProfile)}));
            //IMapper mapper = config.CreateMapper();
        }

    public class OrganizationProfile : Profile
    {
        public OrganizationProfile()
        {
            CreateMap<Video, VideoViewModel>();
            CreateMap<VideoViewModel, Video>();
            // Use CreateMap... Etc.. here (Profile methods are the same as configuration methods)
        }
    }
}