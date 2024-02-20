using KodlamaioCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Remove(Course course);
    
}
