using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CandidateManagementMVC.Models
{
    public class Skill
    {
        public int SkillId { get; set; }

        public string SkillName { get; set; }

        public ICollection<SkillUser> SkillUsers { get; set; }


    }
}
