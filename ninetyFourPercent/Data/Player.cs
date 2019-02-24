using System.ComponentModel.DataAnnotations;

namespace ninetyFourPercent
{
    public class Player

    {
        [Key]
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public long Money { get; set; }
    }
}
