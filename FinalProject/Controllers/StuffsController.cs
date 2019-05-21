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
    public class StuffsController : ApiController
    {
        UnitOfWork uow = new UnitOfWork();
        // GET api/staff
        public IEnumerable<StuffCustom> Get()
        {
            return uow.StuffManger.GetAllBind().Select(x => new StuffCustom { id = x.id, fname = x.fname, lname = x.lname, Afname = x.Afname, Alname = x.Alname, email = x.email, pass = x.pass, phone = x.phone, DOB = x.DOB, JoinDate = x.JoinDate, FiredDate = x.FiredDate, Img = x.Img, status = x.status, RoleId = x.RoleId });
        }

        // GET api/staff/5
        public StuffCustom Get(int id)
        {
            var entity = uow.StuffManger.GetByID(id);
            StuffCustom staff = new StuffCustom();
            staff.id = entity.id;
            staff.fname = entity.fname;
            staff.lname = entity.lname;
            staff.Afname = entity.Afname;
            staff.Alname = entity.Alname;
            staff.email = entity.email;
            staff.pass = entity.pass;
            staff.phone = entity.phone;
            staff.DOB = entity.DOB;
            staff.JoinDate = entity.JoinDate;
            staff.FiredDate = entity.FiredDate;
            staff.Img = entity.Img;
            staff.RoleId = entity.RoleId;
            return staff;
        }

        // POST api/staff
        public bool Post(staff s)
        {
            var id = uow.StuffManger.MaxId(s);
            for (int i = 0; true; i++)
            {
                if (uow.StuffManger.GetByID(id) == null)
                {
                    s.id = id;
                    return uow.StuffManger.AddEntity(s);
                }
                id++;
            }
        }

        // PUT api/staff
        public bool Put(staff s)
        {
            return uow.StuffManger.UpdateEntity(s);
        }

        // DELETE api/staff/5
        public bool Delete(int id)
        {
            var entity = uow.StuffManger.GetByID(id);
            return uow.StuffManger.DeleteEntity(entity);
        }
    }
}
