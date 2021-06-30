using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUTORIALJWT.Model;

namespace TUTORIALJWT.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SkillController : ControllerBase
    {


        //[HttpGet]
        //public JsonResult ShowJson()
        //{
        //    db_latihan_alifContext db = new db_latihan_alifContext();
        //    var data = db.Skills.Where(e => e.SkillId >= 0 || e.SkillName.Contains("a")).ToList();
        //    return new JsonResult(data);
        //}


        [HttpGet]
        public JsonResult GetSkills()
        {
            db_latihan_alifContext db = new db_latihan_alifContext();
            var data = db.Skills.ToList();
            return new JsonResult(data);
        }

       

        [HttpPost]
        public JsonResult Create(Skill skill)
        {
            db_latihan_alifContext db = new db_latihan_alifContext();

            db.Skills.Add(skill);
            db.SaveChanges();

            return new JsonResult("Create Success");
        }


        [HttpPatch]
        public JsonResult Update(Skill skill)
        {
            db_latihan_alifContext db = new db_latihan_alifContext();

            db.Entry(skill).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();

            return new JsonResult("Update Success");
        }


        [HttpDelete]
        public JsonResult Delete(int skillId)
        {
            db_latihan_alifContext db = new db_latihan_alifContext();

            db.Remove(db.Skills.Where(e => e.SkillId == skillId).FirstOrDefault());
            db.SaveChanges();

            return new JsonResult("Delete Success");
        }
    }
}
