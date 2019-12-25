using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CandidateManagementEF.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public byte RoleId { get; set; }

        [Required]
        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
