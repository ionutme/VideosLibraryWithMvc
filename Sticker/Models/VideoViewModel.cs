using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sticker.Models
{
    public class VideoViewModel
    {
        private const string UrlPattern = "^(\\b(([\\w-]+://?|www[.])[^\\s()<>]+(?:\\([\\w\\d]+\\)|([^[:punct:]\\s]|/))))$";

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required(ErrorMessage = "Please enter link to video")]
        [RegularExpression(UrlPattern, ErrorMessage = "Please enter a valid link")]
        public string Link { get; set; }

        //public IEnumerable<CommentViewModel>
    }
}