using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BL.Classes;
using BL.Models;
namespace FinalProject.Controllers
{
    public class CoursesController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Courses
        public IEnumerable<CourseCustom> Get()
        {
            return unitOfWork.CourseManager.GetAllBind().Select(c=> new CourseCustom { code = c.code,crs_AName=c.crs_AName,crs_Name=c.crs_Name });
        }

        // GET: api/Courses/5
        public CourseCustom Get(int id)
        {
            var crsEntity = unitOfWork.CourseManager.GetByID(id);
            CourseCustom course = new CourseCustom();
            course.code = crsEntity.code;
            course.crs_AName = crsEntity.crs_AName;
            course.crs_Name = crsEntity.crs_Name;
            return course;
        }

        // POST: api/Courses
        public bool Post(course crs)
        {
            return unitOfWork.CourseManager.AddEntity(crs);
        }

        // PUT: api/Courses/5
        public bool Put(course crs)
        {
            return unitOfWork.CourseManager.UpdateEntity(crs);
        }

        // DELETE: api/Courses/5
        public bool Delete(int id)
        {
            return unitOfWork.CourseManager.DeleteEntity(unitOfWork.CourseManager.GetByID(id));
        }
    }
}
