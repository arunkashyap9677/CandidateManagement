using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CandidateManagementEF.Models
{
    public class Skill
    {

        public int SkillId { get; set; }

        [Required]
        public string SkillName { get; set; }

        public ICollection<SkillUser> SkillUsers { get; set; }


    }
}
