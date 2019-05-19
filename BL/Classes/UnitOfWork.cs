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
        SchoolDBEntities ctx = new SchoolDBEntities();
        public FeesManager FeesManager
        {
            get
            {
                return new FeesManager(ctx);
                /*if (FeesManager == null)
                {
                    return new FeesManager(ctx);
                }
                else
                {
                    return FeesManager;
                }*/
            }
        }
        public CourseManager CourseManager
        {
            get
            {
                return new CourseManager(ctx);
            }
        }
        public TaskManager TaskManager
        {
            get
            {
                return new TaskManager(ctx);
            }
        }
        public ParentManager ParentManager
        {
            get
            {
                return new ParentManager(ctx);
            }
        }
    }
}
