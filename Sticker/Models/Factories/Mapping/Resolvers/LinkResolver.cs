using AutoMapper;
using Sticker.DataAccess.Entities;

namespace Sticker.Models.Factories.Resolvers
{
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