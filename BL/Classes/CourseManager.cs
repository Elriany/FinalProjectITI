using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL.Classes
{
    public class CourseManager : Repository<course>
    {
        public CourseManager(SchoolDBEntities ctx) : base(ctx)
        {
        }
    }
}
