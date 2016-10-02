using System.Collections.Generic;
using System.Linq;
using Sticker.DataAccess.Entities;
using AutoMapper;

namespace Sticker.Models.Factories
{
    public static class VideoViewModelFactory
    {
        public static VideoViewModel ToViewModel(this Video video)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Video, VideoViewModel>());

            return Mapper.Map<Video, VideoViewModel>(video);
        }

        public static List<VideoViewModel> ToViewModel(this IEnumerable<Video> videos)
        {
            return videos.Select(x => x.ToViewModel()).ToList();
        }
    }
}