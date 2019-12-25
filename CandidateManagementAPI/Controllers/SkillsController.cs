using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CandidateManagementEF;
using CandidateManagementEF.Models;
using AutoMapper;

namespace CandidateManagementAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SkillsController : ControllerBase
    {
        private Repository _repository;
        private IMapper _mapper;
        public SkillsController(Repository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        // GET: api/Skills/GetSkills
        [HttpGet]
        public JsonResult GetSkills()
        {
            List<Skill> skillListEF = _repository.GetSkills();
            List<Models.Skill> skillListAPI = new List<Models.Skill>();
            foreach (Skill skill in skillListEF)
            {
                skillListAPI.Add(_mapper.Map<Models.Skill>(skill));
            }

            return new JsonResult(skillListAPI);
        }


        // GET: api/Skills/GetSkill/1
        [HttpGet("{skillId}")]
        public JsonResult GetSkill(string skillId)
        {
            Skill skillEF = _repository.GetSkill(Convert.ToInt32(skillId));
            Models.Skill skillAPI = new Models.Skill();
           
            skillAPI =  _mapper.Map<Models.Skill>(skillEF);

            return new JsonResult(skillAPI);
        }



        // POST: api/Skills/AddSkill
        [HttpPost]
        public JsonResult AddSkill(Models.Skill skill)
        {
            bool result;
            try
            {
                 result = _repository.AddSkill(_mapper.Map<Skill>(skill));
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                result = false;
            }

            return new JsonResult(result);

        }

        // PUT: api/Skills/UpdateSkill
        [HttpPut]
        public JsonResult UpdateSkill(Models.Skill skill)
        {
            bool result;
            try
            {
                result = _repository.UpdateSkill(_mapper.Map<Skill>(skill));
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                result = false;
            }

            return new JsonResult(result);
        }


        // DELETE: api/ApiWithActions/5
        [HttpDelete("{skillId}")]
        public JsonResult DeleteSkill(string skillId)
        {
            bool result;
            try
            {
                result = _repository.DeleteSkill(skillId);
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                result = false;
            }

            return new JsonResult(result);

        }

        // DELETE ALL SKILLS: api/ApiWithActions/5
        public JsonResult DeleteSkill()
        {
            bool result = true ;
            try
            {
                //result = _repository.DeleteSkill();
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
                result = false;
            }

            return new JsonResult(result);

        }
    }
}
