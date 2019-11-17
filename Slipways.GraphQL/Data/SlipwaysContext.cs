using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GraphQL.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(
            this ModelBuilder modelBuilder)
        {
            var file = new FileInfo(@"Data/waters.json");
            var stream = file.OpenText();
            var str =  stream.ReadToEnd();
            var waters = JsonConvert.DeserializeObject<IEnumerable<Water>>(str);
            modelBuilder.Entity<Water>().HasData(waters);
        }
    }

    public class SlipwaysContext : DbContext
    {
        public DbSet<Water> Waters { get; set; }
        public DbSet<Slipway> Slipways { get; set; }
        public DbSet<Station> Stations { get; set; }

        private readonly ILogger<SlipwaysContext> _logger;

        public SlipwaysContext(
            DbContextOptions options,
            ILogger<SlipwaysContext> logger) : base(options)
        {
            _logger = logger;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));
           modelBuilder.Seed();
        }
    }
}
