using KodlamaioCourse.DataAccess.Abstract;
using KodlamaioCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.Bussiness;

public class CourseManager
{
    private readonly ICourseDal _courseDal;

    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        return _courseDal.GetAll(); 
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Remove(Course course)
    {
        _courseDal.Remove(course);
    }
}
