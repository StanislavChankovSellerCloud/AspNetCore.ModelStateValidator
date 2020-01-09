using System.ComponentModel.DataAnnotations;

namespace AspNetCore.ModelStateValidator.WebApi.Models
{
    public class HeroRequest2 : HeroBaseRequest2
    {
        public Weapon? SpecificWeapon { get; set; } = default!;

        public Equipment? SpecificEquipment { get; set; }
    }

    public class HeroBaseRequest2
    {
        public Weapon MainWeapon { get; set; }

        public Equipment? MainEquipment { get; set; }

        [Required]
        public Accessory Accessory { get; set; }
    }
}
