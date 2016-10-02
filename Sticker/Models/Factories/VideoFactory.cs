using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Sticker.DataAccess.Entities;

namespace Sticker.Models.Factories
{
    public static class VideoFactory
    {
        static VideoFactory()
        {
            Mapper.Initialize(
                cfg => cfg.CreateMap<VideoViewModel, Video>()
                          .ForMember(v => v.Link, f => f.ResolveUsing<LinkResolver>()));
        }

        public static Video ToEntityModel(this VideoViewModel video)
        {
            return Mapper.Map<VideoViewModel, Video>(video);
        }

        public static List<Video> ToEntityModel(this IEnumerable<VideoViewModel> videos)
        {
            return videos.Select(x => ToEntityModel((VideoViewModel) x)).ToList();
        }
    }

    public class LinkResolver : IValueResolver<VideoViewModel, Video, string>
    {
        public string Resolve(VideoViewModel viewModel, Video entity, string member, ResolutionContext context)
        {
            return FormatLink(viewModel.Link);
        }
        private static string FormatLink(string link)
        {
            return link
                    .Replace("https://", string.Empty)
                    .Replace("http://", string.Empty);
        }
    }
}