using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Models
{
    public class Questions
    {
        [Key]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Qustion")]
        [DataType(DataType.Text)]
        public string Question { get; set; }

        public int OptionId { get; set; }

    }
}
