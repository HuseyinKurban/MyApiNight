using MyApiNightDataAccessLayer.Abstract;
using MyApiNightDataAccessLayer.Context;
using MyApiNightDataAccessLayer.Repositories;
using MyApiNightEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApiNightDataAccessLayer.EntityFramework
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategoryDal(ApiContext context) : base(context)
        {
        }
    }
}
