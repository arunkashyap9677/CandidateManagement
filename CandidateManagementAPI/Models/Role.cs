using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateManagementAPI.Models
{
    public class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }

        public byte RoleId { get; set; }

        public string RoleName { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
