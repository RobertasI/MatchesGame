using MatchesGame.Domain;
using System.ComponentModel.DataAnnotations;

namespace MatchesGame.Models
{
    public class GameViewModel
    {
        [Required(ErrorMessage = "Please select game type")]
        public string GameType { get; set; }
        [Required(ErrorMessage = "Please enter first name")]
        public string PlayerOne { get; set; }
        [Required(ErrorMessage = "Please enter second name")]
        public string PlayerTwo { get; set; }

        
    }


}