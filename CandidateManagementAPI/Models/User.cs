﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateManagementAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public byte RoleId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Address { get; set; }

        public string UploadCV { get; set; }

        public Role Role { get; set; }

        public ICollection<SkillUser> SkillUsers { get; set; }



    }
}
