using System;
using System.ComponentModel.DataAnnotations;

namespace Shortener.Web.Models
{
    public class UrlShortener
    {
        [Required]
        public string RawUrl { get; set; }

        public string ShortUrl { get; set; }
    }
}