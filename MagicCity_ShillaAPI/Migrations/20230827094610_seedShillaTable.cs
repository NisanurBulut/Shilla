using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicCity_ShillaAPI.Migrations
{
    /// <inheritdoc />
    public partial class seedShillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Shillas",
                columns: new[] { "Id", "Amenity", "CreatedAt", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Magna Duis Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7068), "P.O. Box 267, 2824 Est Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f98d8b", 755, 1.0, 687, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Eu Placerat Foundation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7097), "4693 Lacinia Av.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#aa281d", 451, 4.0, 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "A Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7099), "Ap #708-6258 Libero. Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#185c75", 417, 4.0, 369, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Sem Pellentesque Consulting", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7100), "P.O. Box 943, 2673 Integer Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#5f8209", 608, 2.0, 47, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "Maecenas Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7102), "933-1316 Aliquet, Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#d5c7fc", 531, 2.0, 728, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "Turpis PC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7103), "Ap #612-6043 Odio. Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#01845b", 948, 3.0, 966, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Sed Dui Consulting", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7104), "516-2918 Orci Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#ff180c", 505, 3.0, 54, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "Rutrum Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7106), "Ap #278-793 Sapien, St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#4ee8c6", 340, 4.0, 591, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "Lorem Luctus Ut Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7107), "Ap #378-1639 Mollis Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#dabaf4", 19, 4.0, 727, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Id Erat Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7110), "Ap #425-1896 Orci, Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#67238c", 432, 3.0, 324, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, "Placerat Cras Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7111), "736-5324 Tellus Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#dd48ea", 475, 4.0, 714, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, "Turpis Consulting", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7113), "Ap #906-3587 Purus Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#5ce06d", 18, 2.0, 183, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, "Sed Libero Proin Consulting", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7114), "645-6096 Aliquet. Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b3f9a7", 173, 3.0, 83, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, "In Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7115), "Ap #563-3481 Suspendisse St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#c1f72c", 519, 1.0, 864, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, "Orci Luctus Institute", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7117), "820-1075 Scelerisque Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#826ce2", 867, 2.0, 366, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, "Amet Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7118), "7374 Dui. Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9deaea", 460, 2.0, 185, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 17, "Quisque Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7120), "P.O. Box 569, 4735 Lorem St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#97ea38", 610, 5.0, 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 18, "Ut Mi Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7122), "P.O. Box 252, 2275 Etiam St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#6b90c4", 173, 4.0, 885, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 19, "Fringilla Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7123), "997-4033 Parturient St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#ef83bb", 922, 1.0, 120, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 20, "Magna Et Ipsum Foundation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7126), "P.O. Box 885, 6278 Condimentum. Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#962913", 113, 3.0, 237, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 21, "Lobortis Risus Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7127), "P.O. Box 506, 4230 Facilisis, St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e5dc59", 258, 3.0, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 22, "Integer Aliquam Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7129), "8483 Amet, Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#1c0575", 344, 3.0, 717, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 23, "Nulla Tincidunt Neque Company", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7130), "929-3803 Natoque Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#35f4eb", 278, 2.0, 818, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 24, "Rutrum Non Hendrerit LLC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7137), "P.O. Box 374, 7965 Sagittis Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e002dc", 377, 1.0, 731, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 25, "Montes Nascetur Ridiculus Associates", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7138), "3650 Sed Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b5c130", 447, 4.0, 414, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 26, "At Velit Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7139), "P.O. Box 377, 7945 Bibendum St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9ac0ed", 997, 3.0, 597, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 27, "Risus A Ultricies Foundation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7141), "8133 Quisque St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#4b5caf", 650, 3.0, 293, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 28, "Mauris Ltd", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7142), "Ap #649-7305 Magna Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#2f4db7", 608, 4.0, 255, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 29, "Ornare Fusce Incorporated", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7143), "Ap #154-1924 Odio Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f2ccff", 444, 3.0, 975, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 30, "Adipiscing Company", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7146), "Ap #698-3320 Et Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b59ae0", 780, 1.0, 600, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 31, "Donec Tincidunt Donec Institute", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7149), "6172 Quisque St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#4d0dad", 830, 3.0, 309, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 32, "Lobortis Quis Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7150), "6502 Diam St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#739fce", 72, 4.0, 734, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 33, "Libero Morbi Accumsan Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7152), "344-9391 Morbi Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b33edd", 954, 4.0, 382, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 34, "Aenean LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7154), "808-1141 Magna. Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#6c43b2", 405, 3.0, 773, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 35, "Erat Nonummy Company", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7156), "P.O. Box 601, 2326 Egestas Av.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#1be2df", 614, 1.0, 683, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 36, "Nunc Ullamcorper Institute", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7157), "Ap #142-6481 Risus. Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#ad2752", 634, 4.0, 598, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 37, "Vivamus Nisi Foundation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7158), "540-5506 Nunc Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#6f70c6", 275, 3.0, 761, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 38, "Bibendum Fermentum Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7160), "1942 Tempus St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#6f9bed", 468, 5.0, 948, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 39, "Non Incorporated", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7162), "P.O. Box 268, 2785 Et, Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#001159", 378, 4.0, 535, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 40, "Integer Sem Elit Inc.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7163), "P.O. Box 494, 9508 Eleifend Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e86fab", 520, 2.0, 67, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 41, "Mus Aenean Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7165), "P.O. Box 136, 3789 Non Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b6d321", 719, 4.0, 344, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 42, "Ac Ltd", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7166), "9223 Faucibus Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f413cb", 41, 4.0, 740, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 43, "Dis PC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7167), "995-9146 Rhoncus. Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#a07ed3", 461, 4.0, 784, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 44, "A Ultricies Adipiscing Institute", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7170), "Ap #921-755 Sed Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e87da8", 625, 3.0, 883, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 45, "Auctor Velit Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7171), "Ap #757-3626 Donec Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#fcd0b3", 722, 4.0, 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 46, "Urna Convallis Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7172), "143-8337 Orci Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#76f7ea", 902, 4.0, 952, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 47, "Lorem Inc.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7174), "Ap #884-6920 Odio Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#66d69c", 23, 4.0, 670, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 48, "Risus Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7176), "Ap #672-903 Sapien. Av.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#eaea0e", 640, 3.0, 332, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 49, "Sed Inc.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7177), "240-6931 Arcu. Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#db6f9c", 650, 1.0, 286, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 50, "Dolor Associates", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7178), "501-4919 Ante St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f9cf45", 198, 2.0, 701, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 51, "Lacus Quisque Company", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7179), "590-2101 Phasellus Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#26e0a8", 274, 5.0, 196, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 52, "Nullam Company", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7181), "1566 Tortor Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9589d3", 340, 4.0, 377, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 53, "Blandit Viverra Donec LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7182), "266-6782 Tristique Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9d41e2", 330, 1.0, 672, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 54, "Semper Rutrum Fusce LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7184), "Ap #145-9213 Et Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e5cb64", 344, 1.0, 518, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 55, "Malesuada Malesuada Integer Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7185), "7000 Ultricies Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#89d14b", 871, 2.0, 642, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 56, "In Hendrerit Associates", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7187), "4389 Turpis Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f4ce42", 264, 4.0, 463, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 57, "Sed Nunc Est Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7191), "621-1395 Semper St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#06a096", 617, 2.0, 349, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 58, "In Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7192), "Ap #603-8858 Nec Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e0f285", 155, 1.0, 626, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 59, "Sed Id Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7255), "Ap #175-5527 Sem Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e5dd00", 108, 3.0, 842, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 60, "Augue Sed Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7258), "735-4990 Dignissim Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#abf48d", 178, 2.0, 131, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 61, "Tincidunt Vehicula LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7259), "7155 Elit. St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#aef4a1", 746, 1.0, 154, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 62, "Lorem Ipsum Associates", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7260), "8322 Ipsum Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#456b01", 535, 2.0, 161, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 63, "Gravida Incorporated", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7264), "Ap #980-2275 Est, St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#c379e0", 845, 1.0, 433, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 64, "Molestie Sodales Inc.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7265), "Ap #871-2940 Nascetur St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e0477f", 128, 4.0, 960, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 65, "In Dolor Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7267), "4158 Blandit Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f79c79", 233, 3.0, 830, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 66, "Aliquam Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7268), "P.O. Box 409, 3141 Proin Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#ba90dd", 584, 3.0, 170, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 67, "Eget Mollis Lectus Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7269), "P.O. Box 269, 2735 Lorem Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#ea7670", 952, 3.0, 296, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 68, "Egestas LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7271), "Ap #863-5298 Urna. St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9fb4ea", 418, 3.0, 533, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 69, "Dapibus Ligula Limited", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7273), "Ap #810-2434 Facilisis Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#f6c7fc", 385, 4.0, 148, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 70, "Molestie Arcu Ltd", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7274), "Ap #893-8389 Congue St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#3aeae7", 72, 1.0, 105, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 71, "Ligula Eu Enim Associates", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7275), "756-6990 Adipiscing St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#78bed3", 439, 4.0, 242, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 72, "Integer Tincidunt Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7278), "855-7170 Urna, Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#687aed", 376, 3.0, 599, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 73, "Sem Nulla Interdum Consulting", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7281), "Ap #661-896 Cras Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#1eed2c", 585, 1.0, 884, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 74, "Tortor Company", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7282), "872-8100 A Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#bdafed", 806, 3.0, 504, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 75, "Odio Sagittis Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7284), "Ap #993-935 Sit Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#8e82ff", 786, 2.0, 394, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 76, "Scelerisque Foundation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7287), "9855 Diam St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b619ea", 520, 5.0, 804, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 77, "Quis Lectus Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7289), "Ap #419-4455 Malesuada Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#40dd4a", 570, 4.0, 267, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 78, "Est Ac Associates", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7290), "Ap #336-3777 Nonummy St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#c15303", 121, 2.0, 332, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 79, "Erat Semper LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7291), "8762 Orci Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#afa4f2", 560, 5.0, 727, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 80, "Ullamcorper Foundation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7293), "149-8936 Nonummy Av.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#86efde", 608, 3.0, 993, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 81, "Est Ac Mattis Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7294), "Ap #534-1107 Metus. Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#e2485a", 482, 3.0, 882, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 82, "Vitae Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7295), "P.O. Box 720, 9003 Arcu Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#1be540", 629, 3.0, 570, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 83, "Duis Ac Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7298), "Ap #211-3822 Adipiscing Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#94ecef", 901, 5.0, 894, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 84, "Enim PC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7302), "P.O. Box 404, 8586 Sollicitudin Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#4ed31d", 700, 2.0, 862, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 85, "Dis Parturient Ltd", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7306), "Ap #892-3444 Metus. St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#60e0b7", 71, 2.0, 537, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 86, "Dictum Inc.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7309), "Ap #183-4643 Interdum Street", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#025782", 33, 1.0, 878, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 87, "Quis Pede PC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7311), "8387 Imperdiet Avenue", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#71f7c1", 48, 3.0, 353, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 88, "Vel Convallis LLC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7312), "377-3871 Eleifend Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9c51ff", 193, 4.0, 184, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 89, "Nulla Dignissim Incorporated", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7314), "P.O. Box 186, 5950 Blandit. Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#54f996", 598, 5.0, 641, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 90, "Enim Diam Ltd", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7315), "Ap #794-199 Interdum Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#d4a4fc", 838, 3.0, 313, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 91, "Erat Nonummy Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7316), "805-9439 Neque Av.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#95eda8", 107, 1.0, 986, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 92, "Lacus LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7318), "8274 Turpis St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#77afdd", 677, 4.0, 258, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 93, "Et Libero LLP", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7319), "Ap #127-3380 Nibh. Av.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#b1f49c", 338, 5.0, 107, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 94, "Elit Pharetra Ut Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7320), "720-2914 Dolor Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#9b7bce", 541, 4.0, 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 95, "Dis Parturient Industries", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7323), "754-1700 Mi St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#77f9d7", 422, 3.0, 782, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 96, "Arcu Vestibulum LLC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7324), "Ap #750-8981 Luctus. Road", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#ffc987", 724, 4.0, 917, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 97, "Pellentesque Sed Dictum PC", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7326), "P.O. Box 870, 9372 Vulputate Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#140a6d", 771, 3.0, 587, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 98, "Et Consulting", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7327), "P.O. Box 631, 6280 Habitant Ave", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#74c433", 765, 2.0, 924, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 99, "Phasellus In Felis Corporation", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7328), "P.O. Box 694, 8037 Nunc Rd.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#cdf7a0", 854, 4.0, 998, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 100, "Mauris Aliquam Corp.", new DateTime(2023, 8, 27, 12, 46, 10, 394, DateTimeKind.Local).AddTicks(7329), "Ap #225-1998 Purus St.", "https://fakeimg.pl/350x200/?text=World&font=lobster", "#098265", 432, 3.0, 654, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Shillas",
                keyColumn: "Id",
                keyValue: 100);
        }
    }
}
