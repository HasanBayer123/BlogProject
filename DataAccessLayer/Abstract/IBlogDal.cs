using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal : IGenericDal<Blog>
    {
        List<Blog> GetListAll();

        //object GetListAll();
        //List<Blog> GetListAll(object value);
        List<Blog> GetListWithCategory();
        List<Blog> GetListWithCategoryByWriter(int id);

    }
}