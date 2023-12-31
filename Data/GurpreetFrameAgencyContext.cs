﻿using Microsoft.EntityFrameworkCore;
using GurpreetFrameAgency.Models;

namespace GurpreetFrameAgency.Data
{
    public class GurpreetFrameAgencyContext : DbContext
    {
        public GurpreetFrameAgencyContext(DbContextOptions<GurpreetFrameAgencyContext> options)
            : base(options)
        {
        }

        public DbSet<Frame> Frame { get; set; }
    }
}