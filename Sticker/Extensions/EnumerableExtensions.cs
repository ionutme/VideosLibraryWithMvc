using System.Collections.Generic;

namespace Sticker.Extensions
{
    public static class EnumerableExtensions
    {
        public static T[] AsCollection<T>(this T item) where T : class
        {
            return new[] {item};
        }
    }
}