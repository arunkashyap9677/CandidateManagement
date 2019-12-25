using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CandidateManagementEF.Models;

namespace CandidateManagementMVC.Mapper
{
    public class DataMapper:Profile
    {
        public DataMapper()
        {
            CreateMap<User, Models.User>();
            CreateMap<Skill, Models.Skill>();
            CreateMap<SkillUser, Models.SkillUser>();
            CreateMap<Role, Models.Role>();


            CreateMap<Models.User, User>();
            CreateMap<Models.Skill, Skill>();
            CreateMap<Models.SkillUser, SkillUser>();
            CreateMap<Models.Role, Role>();

        }
      

    }
}
