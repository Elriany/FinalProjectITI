using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL.Classes
{
    public class AbsenceManager : Repository<tbl_absence>
    {
        public AbsenceManager(SchoolDBEntities ctx) : base(ctx)
        {
        }
    }
}
