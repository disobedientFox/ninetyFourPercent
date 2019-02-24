using System.ComponentModel.DataAnnotations;

namespace ninetyFourPercent
{
    public class Word
    {
        [Key]
        public long Id { get; set; }
        public string SecretWord { get; set; }
        public int Percent { get; set; }
        public Level Level { get; set; }
    }
}
