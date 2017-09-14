using System;
using Microsoft.EntityFrameworkCore;

namespace Shortner.Web.Data
{
    public interface IDbUrlContext
    {
        DbSet<LongUrl> LongUrls { get; set; }
    }
}