using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PuneUniversityVotingSystem.Models
{
    [Table("Users")]
    public class Users
    {
        
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter UserName")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }


        [Required(ErrorMessage = "Enter Email")]
        [DataType(DataType.Text)]
        public string Email { get; set; }



        [Required(ErrorMessage = "Enter Password")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Enter RoleId")]
        [DataType(DataType.Text)]
        public int RoleId { get; set; }
    }
}
