using MagicCity_ShillaAPI.Models.Dto;

namespace MagicCity_ShillaAPI.Data
{
    public static class ShillaStore
    {
        public static List<ShillaDto>
           shillaList = new List<ShillaDto> {
                new ShillaDto
                {
                    Id = 1,
                    Name = "Pool View"
                },
                new ShillaDto
                {
                    Id = 2,
                    Name = "Beach View"
                }
            };
    }
}
