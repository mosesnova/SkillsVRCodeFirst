using System.ComponentModel.DataAnnotations.Schema;

namespace SkillsVRCodeFirst.Models
{
    public class Player
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerat‌ed(System.ComponentM‌​odel.DataAnnotations‌​.Schema.DatabaseGeneratedOp‌​tion.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }
    }
}
