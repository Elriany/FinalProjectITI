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
    public class FeesController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Fees
        public IEnumerable<FeesCustom> Get()
        {
            return unitOfWork.FeesManager.GetAllBind().Select(f=> new FeesCustom { id=f.id,total=f.total??0,paid=f.paid??0,reminder=f.reminder??0 });
        }

        // GET: api/Fees/5
        public FeesCustom Get(int id)
        {
            var entity =  unitOfWork.FeesManager.GetByID(id); //ToDo
            FeesCustom fee = new FeesCustom();
            fee.id = entity.id;
            fee.total = entity.total??0;
            fee.paid = entity.paid??0;
            fee.reminder = entity.reminder??0;
            return fee;
        }

        // post: api/fees
        public bool post(fee f)
        {
            return unitOfWork.FeesManager.AddEntity(f);            
        }

        // PUT: api/Fees/5
        public bool Put(fee f)
        {
            return unitOfWork.FeesManager.UpdateEntity(f);
        }

        // DELETE: api/Fees/5
        public bool Delete(int id)
        {
            var entity = unitOfWork.FeesManager.GetByID(id);
            return unitOfWork.FeesManager.DeleteEntity(entity);
        }
    }
}
