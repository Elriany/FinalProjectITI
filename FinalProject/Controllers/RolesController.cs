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
    public class RolesController : ApiController
    {
        UnitOfWork unitOfWork = new UnitOfWork();
        // GET: api/Roles
        public IEnumerable<RoleCustom> Get()
        {
            return unitOfWork.RolesManager.GetAllBind().Select(r=> new RoleCustom { id = r.id,RuleName=r.RuleName,status=r.status });
        }

        // GET: api/Roles/5
        public RoleCustom Get(int id)
        {
            var roleEntity =  unitOfWork.RolesManager.GetByID(id);
            RoleCustom role = new RoleCustom();
            role.id = roleEntity.id;
            role.RuleName = roleEntity.RuleName;
            role.status = roleEntity.status;
            return role;
        }

        // POST: api/Roles
        public bool Post(tbl_role r)
        {
            var id = unitOfWork.RolesManager.MaxId(r);
            for (int i = 0; true; i++)
            {
                if (unitOfWork.RolesManager.GetByID(id) == null)
                {
                    r.id = id;
                    return unitOfWork.RolesManager.AddEntity(r);
                }
                id++;
            }
        }

        // PUT: api/Roles/5
        public bool Put(tbl_role r)
        {
            return unitOfWork.RolesManager.UpdateEntity(r);
        }

        // DELETE: api/Roles/5
        public bool Delete(int id)
        {
            return unitOfWork.RolesManager.DeleteEntity(unitOfWork.RolesManager.GetByID(id));
        }
    }
}
