using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
	public interface IWriterService:IGenericService<Writer>
	{
        List<Writer> GetWriterById(int id);
        //ıdye göre writer değerini getir.
    }
}
