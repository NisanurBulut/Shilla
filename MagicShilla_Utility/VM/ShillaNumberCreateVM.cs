using MagicShilla_Utility.Dto;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace MagicShilla_Utility.VM
{
    public class ShillaNumberCreateVM
    {
        public ShillaNumberCreateVM()
        {
            this.ShillaNumberCreateDto = new ShillaNumberCreateDto();
        }
        public ShillaNumberCreateDto ShillaNumberCreateDto { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ShillaList { get; set; }
    }
}
