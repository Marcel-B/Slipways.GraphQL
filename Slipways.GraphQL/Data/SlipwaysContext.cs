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
            var input = JsonConvert.DeserializeObject<IEnumerable<Water>>(stream);
            var waters = new HashSet<Water>();

            foreach (var water in input)
            {
                waters.Add(new Water
                {
                    Id = water.Id,
                    Created = DateTime.Now,
                    Longname = water.Longname,
                    Shortname = water.Shortname
                });
            }

            waters.Add(new Water
            {
                Id = Guid.Parse("B1E19997-22AD-4413-89C0-5ADDCDD6E96A"),
                Created = DateTime.Now,
                Longname = "APER TIEF",
                Shortname = "APER TIEF"
            });

            modelBuilder.Entity<Water>().HasData(waters);
            file = new FileInfo(@"Data/stations.json");
            stream = await file.OpenText().ReadToEndAsync();
            var stationsDto = JsonConvert.DeserializeObject<IEnumerable<Data.Dtos.Station>>(stream);
            var stations = new HashSet<Station>();
            foreach (var station in stationsDto)
            {
                stations.Add(new Station
                {
                    Id = station.Id,
                    Created = DateTime.Now,
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

            modelBuilder.Entity<Slipway>().HasData(
                new Slipway
                {
                    Id = Guid.Parse("11ACB81E-0B41-46AA-A079-18C13CDE3F3D"),
                    Created = DateTime.Now,
                    Name = "Zur Alten Fähre, Essen",
                    City = "Essen Kettwig",
                    Postalcode = "45219",
                    Costs = 0.00M,
                    Longitude = 6.9355,
                    Latitude = 51.36,
                    Street = "Zur Alten Fähre 31",
                    WaterFk = Guid.Parse("28E2B1B8-E353-4174-99A5-816229C68BD1"),
                    Rating = -1
                },
                new Slipway
                {
                    Id = Guid.Parse("C6E16AAA-733B-4E1E-AB0E-19BB82669E0D"),
                    Created = DateTime.Now,
                    Name = "Fährstraße 7, Landesbergen",
                    Postalcode = "31628",
                    City = "Landesbergen",
                    Costs = 0,
                    Longitude = 9.1123,
                    Latitude = 52.5534,
                    Street = "Fährstraße 7",
                    WaterFk = Guid.Parse("F965ECF6-2057-479D-A571-3F4E30C1E493"),
                    Rating = -1
                },
                new Slipway
                {
                    Id = Guid.Parse("600EEBCE-5DD4-4DE1-9068-401744A74C01"),
                    Created = DateTime.Now,
                    Name = "Crefelder Yachtclub",
                    City = "Krefeld, Gellep-Stratum",
                    Costs = 10M,
                    Postalcode = "47809",
                    Longitude = 6.69,
                    Rating = -1,
                    Latitude = 51.3366,
                    Street = "Bataverstraße",
                    WaterFk = Guid.Parse("A88EA916-5E6C-4D83-83A9-1D4FDFEF25EC")
                },
                new Slipway
                {
                    Id = Guid.Parse("F0CAA49C-2D84-437A-A1F2-53F56A4E48FD"),
                    Created = DateTime.Now,
                    Name = "Rheinfähre Walsum",
                    Postalcode = "47179",
                    Rating = -1,
                    City = "Alt-Walsum",
                    Costs = 0,
                    Longitude = 6.7,
                    Latitude = 51.5262,
                    Street = "Rheinstraße",
                    WaterFk = Guid.Parse("A88EA916-5E6C-4D83-83A9-1D4FDFEF25EC")
                },
                new Slipway
                {
                    Id = Guid.Parse("BFD617FD-29C5-4614-B976-65320C0F5ECC"),
                    Created = DateTime.Now,
                    Name = "Bootshaus Krekels",
                    City = "Krefeld, Gellep-Stratum",
                    Costs = -1,
                    Postalcode = "47809",
                    Rating = -1,
                    Longitude = 6.6823,
                    Latitude = 51.3412,
                    Street = "Bataverstraße",
                    WaterFk = Guid.Parse("A88EA916-5E6C-4D83-83A9-1D4FDFEF25EC")
                },
                new Slipway
                {
                    Id = Guid.Parse("4EA84C51-A84C-4AEC-BD52-7C9FBA0C0E92"),
                    Created = DateTime.Now,
                    Name = "Pontwert",
                    City = "Duisburg, Ruhrort",
                    Costs = 10.00M,
                    Postalcode = "47059",
                    Rating = -1,
                    Longitude = 6.7243,
                    Latitude = 51.4474,
                    Street = "Am Bört",
                    WaterFk = Guid.Parse("28E2B1B8-E353-4174-99A5-816229C68BD1")
                },
                new Slipway
                {
                    Id = Guid.Parse("3EC52114-07DF-4E6F-83E7-8CB0C6A5E7D7"),
                    Created = DateTime.Now,
                    Name = "An der Bleiche, Meppen",
                    City = "Meppen, Altstadt",
                    Costs = -1M,
                    Postalcode = "49716",
                    Rating = -1,
                    Longitude = 7.2885,
                    Latitude = 52.6936,
                    Street = "",
                    WaterFk = Guid.Parse("ED0E2086-7425-4D2D-B372-D9B219D5638B")
                },
                new Slipway
                {
                    Id = Guid.Parse("18DB0434-5D5E-48E4-8C4C-C7B25B3ED45F"),
                    Created = DateTime.Now,
                    Name = "Alter Fähranleger",
                    City = "Alt-Walsum",
                    Costs = 0,
                    Postalcode = "47179",
                    Rating = -1,
                    Longitude = 6.7067,
                    Latitude = 51.5238,
                    Street = "Fährstraße",
                    WaterFk = Guid.Parse("A88EA916-5E6C-4D83-83A9-1D4FDFEF25EC")
                },
                new Slipway
                {
                    Id = Guid.Parse("9F232734-8907-4A21-9B76-DE97FEB54A3D"),
                    Created = DateTime.Now,
                    Name = "Woltershof",
                    City = "Baerl",
                    Costs = 0,
                    Postalcode = "47199",
                    Rating = -1,
                    Longitude = 6.7147,
                    Latitude = 51.4985,
                    Street = "Woltershofer Straße 18",
                    WaterFk = Guid.Parse("A88EA916-5E6C-4D83-83A9-1D4FDFEF25EC")
                },
                     new Slipway
                     {
                         Id = Guid.Parse("c25cfffb-bc8d-430e-b005-3fe5654967b0"),
                         Created = DateTime.Now,
                         Name = "Campingplatz Cammerzell",
                         City = "Essen, Werde",
                         Costs = -1,
                         Postalcode = "45219",
                         Rating = -1,
                         Longitude = 6.950825,
                         Latitude = 51.359049,
                         Street = "Werdener Str.",
                         WaterFk = Guid.Parse("28E2B1B8-E353-4174-99A5-816229C68BD1")
                     },
                new Slipway
                {
                    Id = Guid.Parse("1fe7ee5a-e9af-4e86-9664-04a0165ce838"),
                    Created = DateTime.Now,
                    Name = "Stellplatz, Enkirch",
                    City = "Enkirch",
                    Costs = 0M,
                    Postalcode = "56850",
                    Rating = 5,
                    Street = "",
                    Latitude = 49.983731,
                    Longitude = 7.119855,
                    WaterFk = Guid.Parse("AAE1F1D4-F79F-4C3A-83D5-DEBFFD711981")
                });

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


            modelBuilder.Entity<SlipwayExtra>().HasData(
                new SlipwayExtra
                {
                    Id = Guid.Parse("dee3ec64-6f87-4a52-b73d-b974c4213a1f"),
                    Created = DateTime.Now,
                    SlipwayFk = Guid.Parse("1fe7ee5a-e9af-4e86-9664-04a0165ce838"),
                    ExtraFk = Guid.Parse("f5836f04-e23b-475a-a079-1e4f3c9c4d87")
                },
                new SlipwayExtra
                {
                    Id = Guid.Parse("aee36a4e-ef66-4a75-b5da-c6650b701690"),
                    Created = DateTime.Now,
                    SlipwayFk = Guid.Parse("c25cfffb-bc8d-430e-b005-3fe5654967b0"),
                    ExtraFk = Guid.Parse("f5836f04-e23b-475a-a079-1e4f3c9c4d87")
                },
                new SlipwayExtra
                {
                    Id = Guid.Parse("0d4b7439-1da5-4447-b0a4-f87d825a6835"),
                    Created = DateTime.Now,
                    SlipwayFk = Guid.Parse("11ACB81E-0B41-46AA-A079-18C13CDE3F3D"),
                    ExtraFk = Guid.Parse("06448fd8-dcc1-4579-947a-8a7b18bc1aab")
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
        public DbSet<Extra> Extras { get; set; }
        public DbSet<SlipwayExtra> SlipwayExtras { get; set; }

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
