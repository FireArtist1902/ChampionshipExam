using System.ComponentModel.DataAnnotations.Schema;

namespace ChampionshipExam.DAL
{
    public class Player
    {
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        public int Number { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Position { get; set; }
    }
}
