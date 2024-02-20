using KodlamaioCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.DataAccess.Abstract
{
    public interface ICategoryDal
    {
        List<Category> GetAll();

    }
}
