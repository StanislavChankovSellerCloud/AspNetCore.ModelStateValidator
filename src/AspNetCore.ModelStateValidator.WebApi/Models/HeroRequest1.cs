namespace AspNetCore.ModelStateValidator.WebApi.Models
{
    public class HeroRequest1 : HeroBaseRequest1
    {
        public Weapon? SpecificWeapon { get; set; } = default!;

        public Equipment SpecificEquipment { get; set; }
    }

    public class HeroBaseRequest1
    {
        public Weapon? MainWeapon { get; set; }

        public Equipment? MainEquipment { get; set; }
    }
}
