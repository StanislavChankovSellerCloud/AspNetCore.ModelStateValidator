namespace AspNetCore.ModelStateValidator.WebApi.Models
{
    public class HeroRequest3 : HeroBaseRequest3
    {
        public Weapon? SpecificWeapon { get; set; } = default!;

        public Equipment? SpecificEquipment { get; set; }
    }

    public class HeroBaseRequest3
    {
        public Weapon MainWeapon { get; set; }

        public Equipment? MainEquipment { get; set; }

        // Removing "Accessory" property will cause to "MainWeapon" property to NOT be validated.
        // Having "Accessory" property will cause "MainWeapon" to be validated
        public Accessory? Accessory { get; set; }
    }
}
