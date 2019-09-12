using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Headhunter.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Headhunter.Controllers
{
    [Route("api/resume")]
    [ApiController]
    public class ResumeController : ControllerBase
    {
        ApplicationContext db;

        public ResumeController(ApplicationContext context)
        {
            this.db = context;
        }

        [HttpGet]
        public List<Resume> Get()
        {
            return db.Resumes.OrderByDescending(x => x.CreatedTime).ToList();
        }

        [HttpGet]
        [Route("userLogin/{userLogin}")]
        public List<Resume> Get(string userLogin)
        {
            int userId = db.Users.FirstOrDefault(x => x.Login == userLogin).Id;
            List<Resume> result = new List<Resume>();

            foreach(var item in db.Resumes.ToList())
            {
                if (item.OwnerId == userId)
                    result.Add(item);
            }

            return result;
        }

        [HttpPost]
        public IActionResult Post([FromBody]ResumeViewModel model)
        {
            if (model == null)
                return BadRequest();

            Resume resume = new Resume();
            resume.City = model.City;
            resume.AbleToRelocate = model.AbleToRelocate;
            resume.DesiredPosition = model.DesiredPosition;
            resume.HasExperience = model.HasExperience;
            resume.DesiredSalary = model.DesiredSalary;
            resume.HighEducations = model.HighEducations;
            resume.Skills = model.Skills;
            resume.Description = model.Description;
            resume.LanguagesKnowlegde = model.LanguagesKnowledge;
            resume.LearnedCourses = model.LearnedCourses;
            resume.OwnerId = db.Users.FirstOrDefault(x => x.Login == model.OwnerLogin).Id;
            resume.CreatedTime = DateTime.Now;

            db.Resumes.Add(resume);
            db.SaveChanges();
            return Ok();
        }
    }
}