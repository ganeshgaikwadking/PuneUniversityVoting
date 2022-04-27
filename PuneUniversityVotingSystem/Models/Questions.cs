using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Models
{
    [Table("Questions")]
    public class Questions
    {
        
        [Key]
        public int QuestionId { get; set; }

        [Required(ErrorMessage = "Qustion")]
        [DataType(DataType.Text)]
        public string Question { get; set; }

        public string Option1 { get; set; }

        public string Option2 { get; set; }

    }
}
