using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DAL;
using BL;
using BL.Classes;
using BL.Models;

namespace FinalProject.Controllers
{
    public class StudentsController : ApiController
    {
        UnitOfWork uow = new UnitOfWork();
        // GET api/student
        public IEnumerable<StudentCustom> Get()
        {
            return uow.StudentManager.GetAllBind().Select(x => new StudentCustom { id = x.id, fname = x.fname, lname = x.lname, Afname = x.Afname, Alname = x.Alname, email = x.email, pass = x.pass, phone = x.phone, DOB = (DateTime)x.DOB, JoinDate = (DateTime)x.JoinDate, FiredDate = (DateTime)x.FiredDate, Img = x.Img, status = x.status, ParentID = x.ParentID, FeesID = x.FeesID });
        }

        // GET api/student/5
        public StudentCustom Get(int id)
        {
            var entity = uow.StudentManager.GetByID(id);
            StudentCustom student = new StudentCustom();
            student.id = entity.id;
            student.fname = entity.fname;
            student.lname = entity.lname;
            student.Afname = entity.Afname;
            student.Alname = entity.Alname;
            student.email = entity.email;
            student.phone = entity.phone;
            student.DOB = (DateTime)entity.DOB;
            student.JoinDate = (DateTime)entity.JoinDate;
            student.FiredDate = (DateTime)entity.FiredDate;
            student.Img = entity.Img;
            student.status = entity.status;
            student.ParentID = entity.ParentID;
            student.FeesID = entity.FeesID;
            return student;
        }

        // POST api/student
        public bool Post(student s)
        {
            var id = uow.StudentManager.MaxId(s);
            for (int i = 0; true; i++)
            {
                if (uow.StudentManager.GetByID(id) == null)
                {
                    s.id = id;
                    return uow.StudentManager.AddEntity(s);
                }
                id++;
            }
        }

        // PUT api/student/5
        public bool Put(student s)
        {
            return uow.StudentManager.UpdateEntity(s);
        }

        // DELETE api/student/5
        public bool Delete(int id)
        {
            var entity = uow.StudentManager.GetByID(id);
            return uow.StudentManager.DeleteEntity(entity);
        }
    }
}
