using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BL.Classes
{
    public class UnitOfWork
    {
        SchoolDBEntities1 ctx = new SchoolDBEntities1();
        public FeesManager FeesManager
        {
            get
            {
                return new FeesManager(ctx);
                //if(FeesManager == null)
                //{
                //    return new FeesManager(ctx);
                //}
                //else
                //{
                //    return FeesManager;
                //}
            }
        }
    }
}
