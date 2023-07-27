using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBlogDal:IGenericDal<Blog>
    {
        List<Blog> GetListWithCategory();
        // kategoriyle birlikte listeyi getir. 
        //Sadece bloglara özel. İlgili entitye ait methot

        List<Blog> GetListWithCategoryByWriter(int id);
        // YAzara göre kategoriyle birlikte listeyi getir. 
    }
}
