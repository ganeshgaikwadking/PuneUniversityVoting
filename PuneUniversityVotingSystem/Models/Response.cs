using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Models
{
    public class Response
    {
        [Key]
        public int ResponseId { get; set; }
        public int UserId { get; set; }

        public int QuetionId { get; set; }
        public string Answer { get; set; }
    }
}
