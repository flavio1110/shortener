using System;

namespace Shortener.Web.Data
{
    public class LongUrl
    {
        public int Id { get; set; }
        public string AltId { get; set; }

        public string Url { get; set; }

        public DateTime Date { get; set; }
    }
}