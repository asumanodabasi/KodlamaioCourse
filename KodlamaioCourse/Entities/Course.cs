using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.Entities
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int TeacherId { get; set; }
        public int CotegoryId { get; set; }
    }
}
