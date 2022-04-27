using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Models
{
    public class QuestionsContext:DbContext
    {
        public DbSet<Questions> questions { get; set; }
    }
}
