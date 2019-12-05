using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using com.b_velop.Slipways.GrQl.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace com.b_velop.Slipways.GrQl.Data
{
    public static class ModelBuilderExtensions
    {
        public async static Task Seed(
            this ModelBuilder modelBuilder)
        {
            var file = new FileInfo(@"Data/waters.json");
            var stream = await file.OpenText().ReadToEndAsync();
            var waters = JsonConvert.DeserializeObject<IEnumerable<Water>>(stream);

            //modelBuilder.Entity<Water>().HasData(waters);
            file = new FileInfo(@"Data/stations.json");
            stream = await file.OpenText().ReadToEndAsync();
            var stationsDto = JsonConvert.DeserializeObject<IEnumerable<Data.Dtos.Station>>(stream);
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

            modelBuilder.Entity<Extra>().HasData(
                new Extra
                {
                    Id = Guid.Parse("f5836f04-e23b-475a-a079-1e4f3c9c4d87"),
                    Created = DateTime.Now,
                    Name = "Campingplatz"
                },
                new Extra
                {
                    Id = Guid.Parse("8976ceb5-19d6-4f5c-a34d-a43801667b40"),
                    Created = DateTime.Now,
                    Name = "Parkplatz"
                },
                new Extra
                {
                    Id = Guid.Parse("06448fd8-dcc1-4579-947a-8a7b18bc1aab"),
                    Created = DateTime.Now,
                    Name = "Steg"
                });

            modelBuilder.Entity<Manufacturer>().HasData(
                new Manufacturer
                {
                    Id = Guid.Parse("45a1882c-4822-4cd1-9621-cebda51bfa05"),
                    Created = DateTime.Now,
                    Name = "Mercury",
                },
                new Manufacturer
                {
                    Id = Guid.Parse("d07683a9-2ffa-4763-a047-31214e8eb9c9"),
                    Created = DateTime.Now,
                    Name = "Yamaha",
                },
                new Manufacturer
                {
                    Id = Guid.Parse("8baa7bf4-cb1d-4d5e-b3c8-ef190dac1c3c"),
                    Created = DateTime.Now,
                    Name = "Suzuki",
                },
                new Manufacturer
                {
                    Id = Guid.Parse("75ee4dd3-5933-4904-9020-5836ec757f02"),
                    Created = DateTime.Now,
                    Name = "Honda",
                },
                new Manufacturer
                {
                    Id = Guid.Parse("102a6d4b-bd31-4428-bc16-e6991a1a9a1d"),
                    Created = DateTime.Now,
                    Name = "Johnson",
                });

            modelBuilder.Entity<Station>().HasData(stations);
        }
    }

    public class SlipwaysContext : DbContext
    {
        public DbSet<Water> Waters { get; set; }
        public DbSet<Slipway> Slipways { get; set; }
        public DbSet<Station> Stations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ManufacturerService> ManufacturerServices { get; set; }
        public DbSet<Port> Ports { get; set; }
        public DbSet<SlipwayExtra> SlipwayExtras { get; set; }
        public DbSet<Extra> Extras { get; set; }

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
