using System;
using Microsoft.EntityFrameworkCore;

namespace Shortener.Web.Data
{
    public interface IDbUrlContext
    {
        DbSet<LongUrl> LongUrls { get; set; }
    }
}