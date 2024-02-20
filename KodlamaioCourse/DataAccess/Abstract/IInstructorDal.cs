using KodlamaioCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.DataAccess.Abstract
{
    public interface IInstructorDal
    {
        List<Instructor> GetAll();
        void Add(Instructor instructor);
        
        void Delete(Instructor instructor);
    }
}
