using Microsoft.VisualBasic;
using SkillsVRCodeFirst.Models;

namespace SkillsVRCodeFirst.Data
{
    public class DbInitializer
    {
        public static void Initialize(RugbyContext context)
        {
            // Look for any students.
            if (context.Player.Any())
            {
                return;   // DB has been seeded
            }

            //var infos = new Player[]
            //{
            //    new Player {Id=1, Name = "YogiHosting", PlaceOfBirth = "XXYY", Height = "10",Weight = "10", DOB = "2014/06/24" },
            //    new Player{Id=2,  Name ="Microsoft", PlaceOfBirth ="XXXX", Height = "10",Weight = "10", DOB = "2014/07/14" },
            //    new Player{Id=3, Name ="Google", PlaceOfBirth="RRRRR", Height = "10",Weight = "10", DOB = "2019/06/18"},
            //    new Player{Id=4, Name ="Apple", PlaceOfBirth ="XADFD", Height = "10",Weight = "10", DOB = "2022/02/02" },
            //    new Player{Id=5, Name ="SpaceX", PlaceOfBirth ="##@$", Height = "10",Weight = "10", DOB = "2030/10/01" }
            //};
            //var infost = new Team[]
            //{
            //    new Team {Id=1, Name = "YogiHosting", GroundCoach = "XXYY", ListOfPlayers = "10",Region = "10"},
            //    new Team{ Id=2, Name ="Microsoft", GroundCoach ="XXXX", ListOfPlayers = "10",Region = "10" },
            //    new Team{Id=3, Name ="Google", GroundCoach="RRRRR", ListOfPlayers = "10",Region= "10"},
            //    new Team{Id=4, Name ="Apple", GroundCoach="XADFD", ListOfPlayers= "10",Region = "10" },
            //    new Team{Id=5, Name ="SpaceX", GroundCoach ="##@$", ListOfPlayers = "10",Region = "10" }
            //};
            var infos = new Player[]
            {
                new Player { Name = "YogiHosting", PlaceOfBirth = "XXYY", Height = "10",Weight = "10", DOB = "2014/06/24" },
                new Player{ Name ="Microsoft", PlaceOfBirth ="XXXX", Height = "10",Weight = "10", DOB = "2014/07/14" },
                new Player{ Name ="Google", PlaceOfBirth="RRRRR", Height = "10",Weight = "10", DOB = "2019/06/18"},
                new Player{ Name ="Apple", PlaceOfBirth ="XADFD", Height = "10",Weight = "10", DOB = "2022/02/02" },
                new Player{ Name ="SpaceX", PlaceOfBirth ="##@$", Height = "10",Weight = "10", DOB = "2030/10/01" }
            };
            var infost = new Team[]
            {
                new Team { Name = "YogiHosting", GroundCoach = "XXYY", ListOfPlayers = "10",Region = "10"},
                new Team{  Name ="Microsoft", GroundCoach ="XXXX", ListOfPlayers = "10",Region = "10" },
                new Team{ Name ="Google", GroundCoach="RRRRR", ListOfPlayers = "10",Region= "10"},
                new Team{ Name ="Apple", GroundCoach="XADFD", ListOfPlayers= "10",Region = "10" },
                new Team{Name ="SpaceX", GroundCoach ="##@$", ListOfPlayers = "10",Region = "10" }
            };
            context.Player.AddRange(infos);
            context.Team.AddRange(infost);
            context.SaveChanges();
        }
    }
}
