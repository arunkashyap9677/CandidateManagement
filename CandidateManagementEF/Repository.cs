using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using CandidateManagementEF.Models;

namespace CandidateManagementEF
{
    public class Repository
    {
        public readonly CMDbContext _cmdbcontext;

        public Repository(CMDbContext cmdbcontext)
        {
            _cmdbcontext = cmdbcontext;

        }

        //get all the skills present in database
        public List<Skill> GetSkills()
        {
            try
            {
                return _cmdbcontext.Skills.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        //get a single skill present in database
        public Skill GetSkill(int skillId)
        {
            try
            {
                return _cmdbcontext.Skills.FirstOrDefault(x => x.SkillId == skillId);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }
        }


        //add new skill to Database
        public bool AddSkill(Skill skill)
        {
            try
            {
                _cmdbcontext.Skills.Add(skill);
                _cmdbcontext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }


        //update skill in database

        public bool UpdateSkill(Skill skill)
        {
            bool result = false;
            try
            {
                var existingSkill = _cmdbcontext.Skills.FirstOrDefault(c => c.SkillId == skill.SkillId);
                existingSkill.SkillName = skill.SkillName;
                _cmdbcontext.Update(existingSkill);
                _cmdbcontext.SaveChanges();
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return result;
        }


        //delete skill from database

        public bool DeleteSkill(string skillId)
        {
            bool result = false;
            try
            {
                var skillToBeDdeleted = _cmdbcontext.Skills.FirstOrDefault(c => c.SkillId == Convert.ToInt32(skillId));
                _cmdbcontext.Remove(skillToBeDdeleted);
               
                _cmdbcontext.SaveChanges();
                result = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }

            return result;
        }




    }
}
