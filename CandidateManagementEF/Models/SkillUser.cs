using System;
using System.Collections.Generic;
using System.Text;

namespace CandidateManagementEF.Models
{
    public class SkillUser
    {

        public int SkillId { get; set; }
        public Skill Skill { get; set; }
        public int Id { get; set; }
        public User User { get; set; }
    }
}
