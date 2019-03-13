using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ninetyFourPercent
{
    public class PlayerProgress
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Player_Id")]
        public virtual Player Player { get; set; }
        [ForeignKey("Level_Id")]
        public virtual Level Level { get; set; }
        [ForeignKey("Word_Id")]
        public virtual Word Word { get; set; }

        public long Player_Id { get; set; }
        public long Level_Id { get; set; }
        public long Word_Id { get; set; }
    }
}
