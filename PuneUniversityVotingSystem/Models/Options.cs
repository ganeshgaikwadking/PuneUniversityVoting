﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Models
{
    public class Options
    {
        [Key]
        public int OptionId { get; set; }

        public string OptionName { get; set; }

        public int QuestionId { get; set; }


    }
}
