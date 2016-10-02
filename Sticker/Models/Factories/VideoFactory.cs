using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Sticker.DataAccess.Entities;

namespace Sticker.Models.Factories
{
    public static class VideoFactory
    {
        /*static VideoFactory()
        {
            Mapper.Initialize(
                cfg => cfg.CreateMap<VideoViewModel, Video>()
                          .ForMember(v => v.Link, f => f.ResolveUsing<LinkResolver>()));
        }*/

        public static Video ToEntityModel(this VideoViewModel video)
        {
            return Mapper.Map<VideoViewModel, Video>(video);
        }

        public static List<Video> ToEntityModel(this IEnumerable<VideoViewModel> videos)
        {
            return videos.Select(ToEntityModel).ToList();
        }
    }
}