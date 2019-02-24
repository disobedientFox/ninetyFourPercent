using System.ComponentModel.DataAnnotations;

namespace ninetyFourPercent
{
    public class Level
    {
        [Key]
        public long Id { get; set; }
        public string Key { get; set; }
        public int KeyType { get; set; }
        public long Module { get; set; }
    }
}
