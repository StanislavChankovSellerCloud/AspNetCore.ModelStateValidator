using System.ComponentModel.DataAnnotations;

namespace AspNetCore.ModelStateValidator.WebApi.Models
{
    public class HeroRequest : HeroBaseRequest
    {
        public Weapon? SpecificWeapon { get; set; } = default!;

        public Equipment? SpecificEquipment { get; set; }
    }

    public class HeroBaseRequest
    {
        public Weapon MainWeapon { get; set; }

        public Equipment? MainEquipment { get; set; }
    }
}