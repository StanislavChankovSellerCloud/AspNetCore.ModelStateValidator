namespace AspNetCore.ModelStateValidator.WebApi.Models
{
    public class Weapon
    {
        public Equipment? Equipment { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
