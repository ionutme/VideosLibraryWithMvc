﻿using System.Collections.Generic;
using System.Linq;
using Sticker.DataAccess.Entities;
using AutoMapper;

namespace Sticker.Models.Factories
{
    public class VideoViewModelFactory
    {
        private readonly IMapper _videoMapper;

        public VideoViewModelFactory(IConfigurationProvider mapperConfig)
        {
            _videoMapper = mapperConfig.CreateMapper();
        }

        public VideoViewModel CreateFrom(Video video)
        {
            return _videoMapper.Map<Video, VideoViewModel>(video);
        }

        public List<VideoViewModel> CreateFrom(IEnumerable<Video> videos)
        {
            return videos.Select(CreateFrom).ToList();
        }
    }
}