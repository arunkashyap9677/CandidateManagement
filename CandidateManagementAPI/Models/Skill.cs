using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateManagementAPI.Models
{
    public class Skill
    {
        public int SkillId { get; set; }

        public string SkillName { get; set; }

        public ICollection<SkillUser> SkillUsers { get; set; }


    }
}
