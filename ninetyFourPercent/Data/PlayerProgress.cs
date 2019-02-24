using System.ComponentModel.DataAnnotations;

namespace ninetyFourPercent
{
    public class PlayerProgress
    {
        [Key]
        public long Id { get; set; }
        public Player Player { get; set; }
        public Level Level { get; set; }
        public Word Word { get; set; }
    }
}
