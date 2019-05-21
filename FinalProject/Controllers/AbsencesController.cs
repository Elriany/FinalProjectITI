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
    public class AbsencesController : ApiController
    {
        UnitOfWork uow = new UnitOfWork();
        // GET api/absence
        public IEnumerable<AbsenceCustom> Get()
        {
            return uow.AbsenceManager.GetAllBind().Select(x => new AbsenceCustom { absenceDate = x.absenceDate, status = x.status,id=x.id });
        }

        // GET api/absence/5
        public AbsenceCustom Get(int id)
        {
            var entity = uow.AbsenceManager.GetByID(id);
            AbsenceCustom abs = new AbsenceCustom();
            abs.id = entity.id;
            abs.status = entity.status;
            abs.absenceDate = entity.absenceDate;
            return abs;
        }

        // POST api/absence
        public bool Post(tbl_absence abs)
        {
            var id = uow.AbsenceManager.MaxId(abs);
            for (int i = 0; true; i++)
            {
                if (uow.AbsenceManager.GetByID(id) == null)
                {
                    abs.id = id;
                    return uow.AbsenceManager.AddEntity(abs);
                }
                id++;
            }
        }

        // PUT api/absence/5
        public bool Put(tbl_absence abs)
        {
            return uow.AbsenceManager.UpdateEntity(abs);
        }

        // DELETE api/absence/5
        public bool Delete(int id)
        {
            var entity = uow.AbsenceManager.GetByID(id);
            return uow.AbsenceManager.DeleteEntity(entity);
        }
    }
}
