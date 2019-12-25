using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateManagementAPI.Models
{
    public class SkillUser
    {

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public int Id { get; set; }
        public User User { get; set; }
    }
}
