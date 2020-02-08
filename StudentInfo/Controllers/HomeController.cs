using StudentInfo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace StudentInfo.Controllers
{
    public class HomeController : Controller
    {
        StudentEntities1 db = new StudentEntities1();
        public ActionResult Index()
        {
            return View();
        }

        //public JsonResult GetStudentList()
        //{
        //    List<JoinClass> StuList = db.Student.Where(x => x.IsDeleted == false).Select(x => new JoinClass {

        //        id = x.id,
        //        FullName = x.FullName,
        //        Email = x.Email,
        //        Course = x.tblCours.CourseName
        //    }).ToList();


        //    return Json(StuList, JsonRequestBehavior.AllowGet);


        //}

    }
}