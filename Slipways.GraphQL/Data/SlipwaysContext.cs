using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using com.b_velop.Slipways.GraphQL.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace com.b_velop.Slipways.GraphQL.Data
{
    public static class ModelBuilderExtensions
    {
        public async static Task Seed(
            this ModelBuilder modelBuilder)
        {
            var file = new FileInfo(@"Data/waters.json");
            var stream = file.Open(FileMode.Open);
            var waters = await JsonSerializer.DeserializeAsync<IEnumerable<Water>>(stream);

            modelBuilder.Entity<Water>().HasData(waters);
            file = new FileInfo(@"Data/stations.json");
            stream = file.Open(FileMode.Open);
            var stationsDto = await JsonSerializer.DeserializeAsync<IEnumerable<Data.Dtos.Station>>(stream);
            var stations = new HashSet<Station>();
            foreach (var station in stationsDto)
            {
                stations.Add(new Station
                {
                    Id = station.Id,
                    Agency = station.Agency,
                    Km = station.Km,
                    Latitude = station.Latitude,
                    Longitude = station.Longitude,
                    Longname = station.Longname,
                    Number = station.Number,
                    Shortname = station.Shortname,
                    WaterFk = waters.FirstOrDefault(_ => _.Shortname == station.Water.Shortname).Id
                });
            }
            modelBuilder.Entity<Station>().HasData(stations);
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

        protected async override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder == null)
                throw new ArgumentNullException(nameof(modelBuilder));
            await modelBuilder.Seed();
        }
    }
}
