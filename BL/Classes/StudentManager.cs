using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BL.Classes
{
    public class StudentManager : Repository<student>
    {
        public StudentManager(SchoolDBEntities ctx) : base(ctx)
        {
        }
    }
}
