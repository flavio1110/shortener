using System;
using System.ComponentModel.DataAnnotations;

namespace Shortner.Web.Models
{
    public class UrlShortener
    {
        [Required]
        public string RawUrl { get; set; }

        public string ShortUrl { get; set; }
    }
}