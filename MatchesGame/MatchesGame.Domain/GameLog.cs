using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MatchesGame.Domain
{
    [Table ("GameLog")]
    public class GameLog
    {
        [Key]
        [Column(Order = 2)]
        public string PlayerName { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Time { get; set; }

        [Key]
        [Column(Order = 3)]
        public string Action { get; set; }
    }
}
