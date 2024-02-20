
using KodlamaioCourse.Bussiness;
using KodlamaioCourse.DataAccess.Abstract;
using KodlamaioCourse.DataAccess.Concrete;
using KodlamaioCourse.Entities;

Console.WriteLine("Hello, World!");

CourseManager courseManager = new CourseManager(new CourseDal());
List<Course> courses=courseManager.GetAll();


for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name+ " / " + courses[i].CotegoryId);
}
