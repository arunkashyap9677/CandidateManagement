using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CandidateManagementEF.Models;

namespace CandidateManagementAPI
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<Skill, Models.Skill>();
            CreateMap<Role, Models.Role>();
            CreateMap<SkillUser, Models.SkillUser>();
            CreateMap<User, Models.User>();

            CreateMap<Models.Skill, Skill>();
            CreateMap<Models.Role, Role>();
            CreateMap<Models.SkillUser, SkillUser>();
            CreateMap<Models.User, User>();
        }
    }
}
