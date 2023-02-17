using System.ComponentModel.DataAnnotations.Schema;

namespace SkillsVRCodeFirst.Models
{
    public class Team
    {
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerat‌ed(System.ComponentM‌​odel.DataAnnotations‌​.Schema.DatabaseGeneratedOp‌​tion.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string GroundCoach { get; set; }

        public string Region { get; set;}

        public string ListOfPlayers { get; set;}

    }
}
