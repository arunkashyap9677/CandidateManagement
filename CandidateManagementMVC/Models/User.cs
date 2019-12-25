using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandidateManagementMVC.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [ForeignKey("Role")]
        public byte RoleId { get; set; }

        [Required]
        [StringLength(40)]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        [Required]
        [StringLength(40)]
        public string Email { get; set; }

        public string Password { get; set; }

        [Required]
        public string Address { get; set; }

        public string UploadCV { get; set; }

        public Role Role { get; set; }

        public ICollection<SkillUser> SkillUsers { get; set; }



    }

}
