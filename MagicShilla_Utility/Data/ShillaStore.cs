﻿using MagicShilla_Utility.Dto;

namespace MagicCity_ShillaAPI.Data
{
    public static class ShillaStore
    {
        public static List<ShillaDto>
           shillaList = new List<ShillaDto> {
                new ShillaDto
                {
                    Id = 1,
                    Name = "Pool View",
                    Sqft =100,
                    Occupancy = 4,
                },
                new ShillaDto
                {
                    Id = 2,
                    Name = "Beach View",
                    Sqft =300,
                    Occupancy = 3
                }
            };
    }
}
