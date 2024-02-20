using KodlamaioCourse.DataAccess.Abstract;
using KodlamaioCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.DataAccess.Concrete
{
    public class CourseDal : ICourseDal
    {
        List<Course> courses;
        public CourseDal()
        {
            Course course = new Course();
            course.Id = 1;
            course.Name = "Java";
            course.CotegoryId = 2;
            course.TeacherId = 1;
            course.Count = 2;

            Course course2 = new Course();
            course.Id = 2;
            course.Name = "Js";
            course.CotegoryId = 3;
            course.TeacherId = 1;
            course.Count = 1;
       
            courses=new List<Course> { course ,course2};
        }
        
        public void Add(Course course)
        {
            
             courses.Add(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public void Remove(Course course)
        {
            courses.Remove(course);
        }

        
    }
}
