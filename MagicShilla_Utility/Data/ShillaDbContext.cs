﻿using MagicShilla_Utility.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagicShilla_Utility.Data
{
    public class ShillaDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShillaDbContext(DbContextOptions<ShillaDbContext> options):base(options)
        {
            
        }
        public DbSet<ApplicationUser> applicationUsers { get; set; }
        public DbSet<LocalUser>  LocalUsers{ get; set; }
        public DbSet<Shilla> Shillas { get; set; }
        public DbSet<ShillaNumber> ShillaNumbers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Shilla>().HasData(

    new Shilla
    {
        Id = 1,
        Name = "#f98d8b",
        Details = "P.O. Box 267, 2824 Est Ave",
        Rate = 1,
        Occupancy = 755,
        Sqft = 687,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Magna Duis Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 2,
        Name = "#aa281d",
        Details = "4693 Lacinia Av.",
        Rate = 4,
        Occupancy = 451,
        Sqft = 183,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Eu Placerat Foundation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 3,
        Name = "#185c75",
        Details = "Ap #708-6258 Libero. Rd.",
        Rate = 4,
        Occupancy = 417,
        Sqft = 369,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "A Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 4,
        Name = "#5f8209",
        Details = "P.O. Box 943, 2673 Integer Ave",
        Rate = 2,
        Occupancy = 608,
        Sqft = 47,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sem Pellentesque Consulting",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 5,
        Name = "#d5c7fc",
        Details = "933-1316 Aliquet, Rd.",
        Rate = 2,
        Occupancy = 531,
        Sqft = 728,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Maecenas Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 6,
        Name = "#01845b",
        Details = "Ap #612-6043 Odio. Rd.",
        Rate = 3,
        Occupancy = 948,
        Sqft = 966,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Turpis PC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 7,
        Name = "#ff180c",
        Details = "516-2918 Orci Road",
        Rate = 3,
        Occupancy = 505,
        Sqft = 54,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sed Dui Consulting",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 8,
        Name = "#4ee8c6",
        Details = "Ap #278-793 Sapien, St.",
        Rate = 4,
        Occupancy = 340,
        Sqft = 591,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Rutrum Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 9,
        Name = "#dabaf4",
        Details = "Ap #378-1639 Mollis Rd.",
        Rate = 4,
        Occupancy = 19,
        Sqft = 727,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lorem Luctus Ut Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 10,
        Name = "#67238c",
        Details = "Ap #425-1896 Orci, Street",
        Rate = 3,
        Occupancy = 432,
        Sqft = 324,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Id Erat Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 11,
        Name = "#dd48ea",
        Details = "736-5324 Tellus Rd.",
        Rate = 4,
        Occupancy = 475,
        Sqft = 714,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Placerat Cras Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 12,
        Name = "#5ce06d",
        Details = "Ap #906-3587 Purus Road",
        Rate = 2,
        Occupancy = 18,
        Sqft = 183,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Turpis Consulting",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 13,
        Name = "#b3f9a7",
        Details = "645-6096 Aliquet. Rd.",
        Rate = 3,
        Occupancy = 173,
        Sqft = 83,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sed Libero Proin Consulting",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 14,
        Name = "#c1f72c",
        Details = "Ap #563-3481 Suspendisse St.",
        Rate = 1,
        Occupancy = 519,
        Sqft = 864,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "In Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 15,
        Name = "#826ce2",
        Details = "820-1075 Scelerisque Ave",
        Rate = 2,
        Occupancy = 867,
        Sqft = 366,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Orci Luctus Institute",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 16,
        Name = "#9deaea",
        Details = "7374 Dui. Street",
        Rate = 2,
        Occupancy = 460,
        Sqft = 185,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Amet Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 17,
        Name = "#97ea38",
        Details = "P.O. Box 569, 4735 Lorem St.",
        Rate = 5,
        Occupancy = 610,
        Sqft = 26,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Quisque Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 18,
        Name = "#6b90c4",
        Details = "P.O. Box 252, 2275 Etiam St.",
        Rate = 4,
        Occupancy = 173,
        Sqft = 885,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Ut Mi Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 19,
        Name = "#ef83bb",
        Details = "997-4033 Parturient St.",
        Rate = 1,
        Occupancy = 922,
        Sqft = 120,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Fringilla Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 20,
        Name = "#962913",
        Details = "P.O. Box 885, 6278 Condimentum. Avenue",
        Rate = 3,
        Occupancy = 113,
        Sqft = 237,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Magna Et Ipsum Foundation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 21,
        Name = "#e5dc59",
        Details = "P.O. Box 506, 4230 Facilisis, St.",
        Rate = 3,
        Occupancy = 258,
        Sqft = 7,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lobortis Risus Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 22,
        Name = "#1c0575",
        Details = "8483 Amet, Road",
        Rate = 3,
        Occupancy = 344,
        Sqft = 717,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Integer Aliquam Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 23,
        Name = "#35f4eb",
        Details = "929-3803 Natoque Rd.",
        Rate = 2,
        Occupancy = 278,
        Sqft = 818,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Nulla Tincidunt Neque Company",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 24,
        Name = "#e002dc",
        Details = "P.O. Box 374, 7965 Sagittis Rd.",
        Rate = 1,
        Occupancy = 377,
        Sqft = 731,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Rutrum Non Hendrerit LLC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 25,
        Name = "#b5c130",
        Details = "3650 Sed Street",
        Rate = 4,
        Occupancy = 447,
        Sqft = 414,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Montes Nascetur Ridiculus Associates",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 26,
        Name = "#9ac0ed",
        Details = "P.O. Box 377, 7945 Bibendum St.",
        Rate = 3,
        Occupancy = 997,
        Sqft = 597,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "At Velit Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 27,
        Name = "#4b5caf",
        Details = "8133 Quisque St.",
        Rate = 3,
        Occupancy = 650,
        Sqft = 293,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Risus A Ultricies Foundation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 28,
        Name = "#2f4db7",
        Details = "Ap #649-7305 Magna Street",
        Rate = 4,
        Occupancy = 608,
        Sqft = 255,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Mauris Ltd",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 29,
        Name = "#f2ccff",
        Details = "Ap #154-1924 Odio Ave",
        Rate = 3,
        Occupancy = 444,
        Sqft = 975,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Ornare Fusce Incorporated",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 30,
        Name = "#b59ae0",
        Details = "Ap #698-3320 Et Ave",
        Rate = 1,
        Occupancy = 780,
        Sqft = 600,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Adipiscing Company",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 31,
        Name = "#4d0dad",
        Details = "6172 Quisque St.",
        Rate = 3,
        Occupancy = 830,
        Sqft = 309,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Donec Tincidunt Donec Institute",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 32,
        Name = "#739fce",
        Details = "6502 Diam St.",
        Rate = 4,
        Occupancy = 72,
        Sqft = 734,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lobortis Quis Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 33,
        Name = "#b33edd",
        Details = "344-9391 Morbi Road",
        Rate = 4,
        Occupancy = 954,
        Sqft = 382,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Libero Morbi Accumsan Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 34,
        Name = "#6c43b2",
        Details = "808-1141 Magna. Rd.",
        Rate = 3,
        Occupancy = 405,
        Sqft = 773,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Aenean LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 35,
        Name = "#1be2df",
        Details = "P.O. Box 601, 2326 Egestas Av.",
        Rate = 1,
        Occupancy = 614,
        Sqft = 683,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Erat Nonummy Company",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 36,
        Name = "#ad2752",
        Details = "Ap #142-6481 Risus. Street",
        Rate = 4,
        Occupancy = 634,
        Sqft = 598,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Nunc Ullamcorper Institute",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 37,
        Name = "#6f70c6",
        Details = "540-5506 Nunc Road",
        Rate = 3,
        Occupancy = 275,
        Sqft = 761,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Vivamus Nisi Foundation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 38,
        Name = "#6f9bed",
        Details = "1942 Tempus St.",
        Rate = 5,
        Occupancy = 468,
        Sqft = 948,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Bibendum Fermentum Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 39,
        Name = "#001159",
        Details = "P.O. Box 268, 2785 Et, Road",
        Rate = 4,
        Occupancy = 378,
        Sqft = 535,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Non Incorporated",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 40,
        Name = "#e86fab",
        Details = "P.O. Box 494, 9508 Eleifend Ave",
        Rate = 2,
        Occupancy = 520,
        Sqft = 67,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Integer Sem Elit Inc.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 41,
        Name = "#b6d321",
        Details = "P.O. Box 136, 3789 Non Avenue",
        Rate = 4,
        Occupancy = 719,
        Sqft = 344,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Mus Aenean Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 42,
        Name = "#f413cb",
        Details = "9223 Faucibus Rd.",
        Rate = 4,
        Occupancy = 41,
        Sqft = 740,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Ac Ltd",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 43,
        Name = "#a07ed3",
        Details = "995-9146 Rhoncus. Rd.",
        Rate = 4,
        Occupancy = 461,
        Sqft = 784,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Dis PC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 44,
        Name = "#e87da8",
        Details = "Ap #921-755 Sed Ave",
        Rate = 3,
        Occupancy = 625,
        Sqft = 883,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "A Ultricies Adipiscing Institute",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 45,
        Name = "#fcd0b3",
        Details = "Ap #757-3626 Donec Ave",
        Rate = 4,
        Occupancy = 722,
        Sqft = 170,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Auctor Velit Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 46,
        Name = "#76f7ea",
        Details = "143-8337 Orci Street",
        Rate = 4,
        Occupancy = 902,
        Sqft = 952,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Urna Convallis Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 47,
        Name = "#66d69c",
        Details = "Ap #884-6920 Odio Rd.",
        Rate = 4,
        Occupancy = 23,
        Sqft = 670,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lorem Inc.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 48,
        Name = "#eaea0e",
        Details = "Ap #672-903 Sapien. Av.",
        Rate = 3,
        Occupancy = 640,
        Sqft = 332,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Risus Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 49,
        Name = "#db6f9c",
        Details = "240-6931 Arcu. Ave",
        Rate = 1,
        Occupancy = 650,
        Sqft = 286,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sed Inc.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 50,
        Name = "#f9cf45",
        Details = "501-4919 Ante St.",
        Rate = 2,
        Occupancy = 198,
        Sqft = 701,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Dolor Associates",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 51,
        Name = "#26e0a8",
        Details = "590-2101 Phasellus Rd.",
        Rate = 5,
        Occupancy = 274,
        Sqft = 196,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lacus Quisque Company",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 52,
        Name = "#9589d3",
        Details = "1566 Tortor Avenue",
        Rate = 4,
        Occupancy = 340,
        Sqft = 377,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Nullam Company",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 53,
        Name = "#9d41e2",
        Details = "266-6782 Tristique Street",
        Rate = 1,
        Occupancy = 330,
        Sqft = 672,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Blandit Viverra Donec LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 54,
        Name = "#e5cb64",
        Details = "Ap #145-9213 Et Ave",
        Rate = 1,
        Occupancy = 344,
        Sqft = 518,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Semper Rutrum Fusce LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 55,
        Name = "#89d14b",
        Details = "7000 Ultricies Rd.",
        Rate = 2,
        Occupancy = 871,
        Sqft = 642,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Malesuada Malesuada Integer Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 56,
        Name = "#f4ce42",
        Details = "4389 Turpis Rd.",
        Rate = 4,
        Occupancy = 264,
        Sqft = 463,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "In Hendrerit Associates",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 57,
        Name = "#06a096",
        Details = "621-1395 Semper St.",
        Rate = 2,
        Occupancy = 617,
        Sqft = 349,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sed Nunc Est Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 58,
        Name = "#e0f285",
        Details = "Ap #603-8858 Nec Avenue",
        Rate = 1,
        Occupancy = 155,
        Sqft = 626,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "In Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 59,
        Name = "#e5dd00",
        Details = "Ap #175-5527 Sem Ave",
        Rate = 3,
        Occupancy = 108,
        Sqft = 842,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sed Id Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 60,
        Name = "#abf48d",
        Details = "735-4990 Dignissim Street",
        Rate = 2,
        Occupancy = 178,
        Sqft = 131,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Augue Sed Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 61,
        Name = "#aef4a1",
        Details = "7155 Elit. St.",
        Rate = 1,
        Occupancy = 746,
        Sqft = 154,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Tincidunt Vehicula LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 62,
        Name = "#456b01",
        Details = "8322 Ipsum Avenue",
        Rate = 2,
        Occupancy = 535,
        Sqft = 161,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lorem Ipsum Associates",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 63,
        Name = "#c379e0",
        Details = "Ap #980-2275 Est, St.",
        Rate = 1,
        Occupancy = 845,
        Sqft = 433,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Gravida Incorporated",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 64,
        Name = "#e0477f",
        Details = "Ap #871-2940 Nascetur St.",
        Rate = 4,
        Occupancy = 128,
        Sqft = 960,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Molestie Sodales Inc.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 65,
        Name = "#f79c79",
        Details = "4158 Blandit Rd.",
        Rate = 3,
        Occupancy = 233,
        Sqft = 830,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "In Dolor Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 66,
        Name = "#ba90dd",
        Details = "P.O. Box 409, 3141 Proin Ave",
        Rate = 3,
        Occupancy = 584,
        Sqft = 170,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Aliquam Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 67,
        Name = "#ea7670",
        Details = "P.O. Box 269, 2735 Lorem Road",
        Rate = 3,
        Occupancy = 952,
        Sqft = 296,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Eget Mollis Lectus Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 68,
        Name = "#9fb4ea",
        Details = "Ap #863-5298 Urna. St.",
        Rate = 3,
        Occupancy = 418,
        Sqft = 533,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Egestas LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 69,
        Name = "#f6c7fc",
        Details = "Ap #810-2434 Facilisis Rd.",
        Rate = 4,
        Occupancy = 385,
        Sqft = 148,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Dapibus Ligula Limited",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 70,
        Name = "#3aeae7",
        Details = "Ap #893-8389 Congue St.",
        Rate = 1,
        Occupancy = 72,
        Sqft = 105,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Molestie Arcu Ltd",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 71,
        Name = "#78bed3",
        Details = "756-6990 Adipiscing St.",
        Rate = 4,
        Occupancy = 439,
        Sqft = 242,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Ligula Eu Enim Associates",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 72,
        Name = "#687aed",
        Details = "855-7170 Urna, Rd.",
        Rate = 3,
        Occupancy = 376,
        Sqft = 599,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Integer Tincidunt Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 73,
        Name = "#1eed2c",
        Details = "Ap #661-896 Cras Avenue",
        Rate = 1,
        Occupancy = 585,
        Sqft = 884,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Sem Nulla Interdum Consulting",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 74,
        Name = "#bdafed",
        Details = "872-8100 A Rd.",
        Rate = 3,
        Occupancy = 806,
        Sqft = 504,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Tortor Company",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 75,
        Name = "#8e82ff",
        Details = "Ap #993-935 Sit Road",
        Rate = 2,
        Occupancy = 786,
        Sqft = 394,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Odio Sagittis Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 76,
        Name = "#b619ea",
        Details = "9855 Diam St.",
        Rate = 5,
        Occupancy = 520,
        Sqft = 804,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Scelerisque Foundation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 77,
        Name = "#40dd4a",
        Details = "Ap #419-4455 Malesuada Street",
        Rate = 4,
        Occupancy = 570,
        Sqft = 267,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Quis Lectus Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 78,
        Name = "#c15303",
        Details = "Ap #336-3777 Nonummy St.",
        Rate = 2,
        Occupancy = 121,
        Sqft = 332,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Est Ac Associates",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 79,
        Name = "#afa4f2",
        Details = "8762 Orci Rd.",
        Rate = 5,
        Occupancy = 560,
        Sqft = 727,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Erat Semper LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 80,
        Name = "#86efde",
        Details = "149-8936 Nonummy Av.",
        Rate = 3,
        Occupancy = 608,
        Sqft = 993,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Ullamcorper Foundation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 81,
        Name = "#e2485a",
        Details = "Ap #534-1107 Metus. Street",
        Rate = 3,
        Occupancy = 482,
        Sqft = 882,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Est Ac Mattis Corp.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 82,
        Name = "#1be540",
        Details = "P.O. Box 720, 9003 Arcu Rd.",
        Rate = 3,
        Occupancy = 629,
        Sqft = 570,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Vitae Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 83,
        Name = "#94ecef",
        Details = "Ap #211-3822 Adipiscing Road",
        Rate = 5,
        Occupancy = 901,
        Sqft = 894,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Duis Ac Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 84,
        Name = "#4ed31d",
        Details = "P.O. Box 404, 8586 Sollicitudin Avenue",
        Rate = 2,
        Occupancy = 700,
        Sqft = 862,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Enim PC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 85,
        Name = "#60e0b7",
        Details = "Ap #892-3444 Metus. St.",
        Rate = 2,
        Occupancy = 71,
        Sqft = 537,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Dis Parturient Ltd",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 86,
        Name = "#025782",
        Details = "Ap #183-4643 Interdum Street",
        Rate = 1,
        Occupancy = 33,
        Sqft = 878,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Dictum Inc.",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 87,
        Name = "#71f7c1",
        Details = "8387 Imperdiet Avenue",
        Rate = 3,
        Occupancy = 48,
        Sqft = 353,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Quis Pede PC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 88,
        Name = "#9c51ff",
        Details = "377-3871 Eleifend Rd.",
        Rate = 4,
        Occupancy = 193,
        Sqft = 184,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Vel Convallis LLC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 89,
        Name = "#54f996",
        Details = "P.O. Box 186, 5950 Blandit. Ave",
        Rate = 5,
        Occupancy = 598,
        Sqft = 641,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Nulla Dignissim Incorporated",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 90,
        Name = "#d4a4fc",
        Details = "Ap #794-199 Interdum Road",
        Rate = 3,
        Occupancy = 838,
        Sqft = 313,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Enim Diam Ltd",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 91,
        Name = "#95eda8",
        Details = "805-9439 Neque Av.",
        Rate = 1,
        Occupancy = 107,
        Sqft = 986,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Erat Nonummy Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 92,
        Name = "#77afdd",
        Details = "8274 Turpis St.",
        Rate = 4,
        Occupancy = 677,
        Sqft = 258,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Lacus LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 93,
        Name = "#b1f49c",
        Details = "Ap #127-3380 Nibh. Av.",
        Rate = 5,
        Occupancy = 338,
        Sqft = 107,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Et Libero LLP",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 94,
        Name = "#9b7bce",
        Details = "720-2914 Dolor Rd.",
        Rate = 4,
        Occupancy = 541,
        Sqft = 13,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Elit Pharetra Ut Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 95,
        Name = "#77f9d7",
        Details = "754-1700 Mi St.",
        Rate = 3,
        Occupancy = 422,
        Sqft = 782,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Dis Parturient Industries",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 96,
        Name = "#ffc987",
        Details = "Ap #750-8981 Luctus. Road",
        Rate = 4,
        Occupancy = 724,
        Sqft = 917,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Arcu Vestibulum LLC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 97,
        Name = "#140a6d",
        Details = "P.O. Box 870, 9372 Vulputate Rd.",
        Rate = 3,
        Occupancy = 771,
        Sqft = 587,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Pellentesque Sed Dictum PC",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 98,
        Name = "#74c433",
        Details = "P.O. Box 631, 6280 Habitant Ave",
        Rate = 2,
        Occupancy = 765,
        Sqft = 924,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Et Consulting",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 99,
        Name = "#cdf7a0",
        Details = "P.O. Box 694, 8037 Nunc Rd.",
        Rate = 4,
        Occupancy = 854,
        Sqft = 998,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Phasellus In Felis Corporation",
        CreatedAt = DateTime.Now,
    },
    new Shilla
    {
        Id = 100,
        Name = "#098265",
        Details = "Ap #225-1998 Purus St.",
        Rate = 3,
        Occupancy = 432,
        Sqft = 654,
        ImageUrl = "https://fakeimg.pl/350x200/?text=World&font=lobster",
        Amenity = "Mauris Aliquam Corp.",
        CreatedAt = DateTime.Now,
    }
            );
        }
    }
}
