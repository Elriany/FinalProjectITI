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
    public class LevelsController : ApiController
    {
        UnitOfWork uow = new UnitOfWork();
        // GET api/level
        public IEnumerable<LevelCustom> Get()
        {
            return uow.LevelManager.GetAllBind().Select(x => new LevelCustom { id = x.id, levelAName = x.levelAName, levelName = x.levelName, fees = x.fees, scheduleFile = x.scheduleFile });
        }

        // GET api/level/5
        public LevelCustom Get(int id)
        {
            var entity = uow.LevelManager.GetByID(id);
            LevelCustom level = new LevelCustom();
            level.id = entity.id;
            level.levelAName = entity.levelAName;
            level.levelName = entity.levelName;
            level.scheduleFile = entity.scheduleFile;
            return level;
        }

        // POST api/level
        public bool Post(ClassLevel l)
        {
            var id = uow.LevelManager.MaxId(l);
            for (int i = 0; true; i++)
            {
                if (uow.LevelManager.GetByID(id) == null)
                {
                    l.id = id;
                    return uow.LevelManager.AddEntity(l);
                }
                id++;
            }
        }

        // PUT api/level/5
        public bool Put(ClassLevel l)
        {
            return uow.LevelManager.UpdateEntity(l);
        }

        // DELETE api/level/5
        public bool Delete(int id)
        {
            var entity = uow.LevelManager.GetByID(id);
            return uow.LevelManager.DeleteEntity(entity);
        }
    }
}
