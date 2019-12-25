using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CandidateManagementEF;
using CandidateManagementEF.Models;
using AutoMapper;
using CandidateManagementMVC.ApiService;
using System.Net.Http;
using Microsoft.Extensions.Configuration;

namespace CandidateManagementMVC.Controllers
{
    public class SkillController : Controller
    {
        private Repository _repository;
        private IMapper _mapper;
        IConfiguration configuration;

        public SkillController(Repository repository, IMapper mapper, IConfiguration configuration)
        {
            _repository = repository;
            _mapper = mapper;
            this.configuration = configuration;
        }


        // GET: Skill
        public ActionResult Index()
        {
            try
            {
                ServiceRepository serviceRepository = new ServiceRepository(configuration);
                HttpResponseMessage response = serviceRepository.GetResponse("api/skills/GetSkills");
                response.EnsureSuccessStatusCode();
                List<Models.Skill> skillsMVC = response.Content.ReadAsAsync<List<Models.Skill>>().Result;
                return View(skillsMVC);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View("Error");
            }

            /*try
            {
                var skillListEF = _repository.GetSkills();
                List<Models.Skill> skillListMVC = new List<Models.Skill>();
                foreach (var skill in skillListEF)
                {
                    skillListMVC.Add(_mapper.Map<Models.Skill>(skill));
                }
                return View(skillListMVC);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View("Error");
            }*/

        }


        //GET  : Particular Skill Details
        public ActionResult Details(string skillId)
        {
            try
            {
                ServiceRepository serviceRepository = new ServiceRepository(configuration);
                HttpResponseMessage response = serviceRepository.GetResponse("api/skills/GetSkill/"+skillId);
                response.EnsureSuccessStatusCode();
                Models.Skill  skillMVC = response.Content.ReadAsAsync<Models.Skill>().Result;
                return View(skillMVC);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View("Error");
            }
        }


        //Add new skill
        public ActionResult AddSkill(Models.Skill skillObjMVC)
        {
            return View(skillObjMVC);
        }


        //Save new skill to database
        [HttpPost]
        public ActionResult SaveSkill(Models.Skill skillObjMVC)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ServiceRepository serviceRepository = new ServiceRepository(configuration);
                    HttpResponseMessage response = serviceRepository.PostRequest("api/skills/AddSkill", skillObjMVC);
                    response.EnsureSuccessStatusCode();
                    if (response.Content.ReadAsAsync<bool>().Result)
                        return View("Success");
                    return View("Error");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return View("Error");
                }
            }

            return RedirectToAction("AddSkill", skillObjMVC);

            /* if (ModelState.IsValid)
             {

                 Skill skillObjEF = _mapper.Map<Skill>(skillObjMVC);
                 _repository.AddSkill(skillObjEF);
                 return RedirectToAction("Index");

             }

             return RedirectToAction("AddSkill", skillObjMVC);
             */
        }

        // GET: Skill/Create
        public ActionResult Edit(string skillId)
        {
            try
            {
                ServiceRepository serviceRepository = new ServiceRepository(configuration);
                HttpResponseMessage response = serviceRepository.GetResponse("api/skills/GetSkill/" + skillId);
                response.EnsureSuccessStatusCode();
                Models.Skill skillMVC = response.Content.ReadAsAsync<Models.Skill>().Result;
                return View(skillMVC);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return View("Error");
            }
        }


        //EDIT : Save Edited skill to database
        [HttpPost]
        public ActionResult EditSkill(Models.Skill skillObjMVC)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    ServiceRepository serviceRepository = new ServiceRepository(configuration);
                    HttpResponseMessage response = serviceRepository.PutRequest("api/skills/UpdateSkill", skillObjMVC);
                    response.EnsureSuccessStatusCode();
                    if (response.Content.ReadAsAsync<bool>().Result)
                        return View("Success");
                    return View("Error");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                    return View("Error");
                }
            }

            return RedirectToAction("Edit", skillObjMVC);


        }



        // POST: Skill/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }   


        // POST: Skill/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Skill/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Skill/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}