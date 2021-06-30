using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TUTORIALJWT.Models;

namespace TUTORIALJWT.Controllers
{
    //[Authorize]
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DataPegawaiController : ControllerBase
    {
        //private int idPegawai;

        //[HttpGet]
        //public string Show()
        //{
        //    return "hello word";
        //}

        //[HttpGet]
        //public JsonResult Showjson()
        //{
        //    //return new JsonResult(new { one = "alif", two = "widi", nama ="Alif widiyanto" }); 
        //    db_alifContext db = new db_alifContext();
        //    var data = db.TblPegawai.Where(e => e.Alamat.Contains("Jak")).ToList();
        //    return new JsonResult(data);
        //}
        
        //[HttpGet]
        ////[Authorize]
        //public JsonResult List()
        //{
        //    List<Pegawai> pegawais = new List<Pegawai>();
        //    pegawais.Add(new Pegawai() { Alamat = "depok", Nama = "Alif" });
        //    pegawais.Add(new Pegawai() { Alamat = "Bogor", Nama = "gunwan" });

        //    return new JsonResult(pegawais);
        //}

        //[HttpPost]
        //public JsonResult Add(string Nama , string Alamat)
        //{
        //    List<Pegawai> pegawais = new List<Pegawai>();

        //    Pegawai pegawai1 = new Pegawai();
        //    pegawai1.Nama = Nama;
        //    pegawai1.Alamat = Alamat;

        //    return new JsonResult("Add sukses");
        //}



        //[HttpPost]
        //public JsonResult Add2(Pegawai pegawai)
        //{
        //    return new JsonResult("Add sukses");
        //}
        //[HttpPost]
        //public JsonResult DataAdd(TblPegawai tblPegawai)
        //{
        //    db_alifContext db = new db_alifContext();
        //    db.TblPegawai.Add(tblPegawai);
        //    db.SaveChanges();
        //    return new JsonResult("Add Success");
        //}

        //[HttpPost]
        //public JsonResult DataUpdate(TblPegawai tblPegawai)
        //{
        //    db_alifContext db = new db_alifContext();
        //    db.Entry(tblPegawai).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    db.SaveChanges();
        //    return new JsonResult("Update success");
        //}

        //[HttpDelete]
        //public JsonResult DataDelete()
        //{
        //    db_alifContext db = new db_alifContext();
        //    db.Remove(db.TblPegawai.Where(e => e.Idpegawai == idPegawai).FirstOrDefault());
        //    db.SaveChanges();
        //    return new JsonResult("Delete success");
        //}

        //[HttpGet]
        //public JsonResult DataDetail()
        //{
        //    db_alifContext db = new db_alifContext();
        //    var data =  db.TblPegawai.Where(e => e.Idpegawai == idPegawai).FirstOrDefault();
        //    return new JsonResult(data);
        //}
    }
}
