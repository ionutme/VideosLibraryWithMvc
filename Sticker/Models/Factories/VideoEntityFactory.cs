using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Sticker.DataAccess.Entities;

namespace Sticker.Models.Factories
{
    public class VideoEntityFactory
    {
        private readonly IMapper _videoMapper;

        public VideoEntityFactory(IConfigurationProvider mapperConfig)
        {
            _videoMapper = mapperConfig.CreateMapper();
        }

        public Video CreateFrom(VideoViewModel video)
        {
            return _videoMapper.Map<VideoViewModel, Video>(video);
        }

        public List<Video> CreateFrom(IEnumerable<VideoViewModel> videos)
        {
            return videos.Select(CreateFrom).ToList();
        }
    }
}