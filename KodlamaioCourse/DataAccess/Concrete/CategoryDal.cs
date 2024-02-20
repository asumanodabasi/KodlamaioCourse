using KodlamaioCourse.DataAccess.Abstract;
using KodlamaioCourse.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KodlamaioCourse.DataAccess.Concrete
{
    public class CategoryDal : ICategoryDal
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryDal(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}
