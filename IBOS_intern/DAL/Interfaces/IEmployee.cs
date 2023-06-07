using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
   public interface IEmployee <T ,ID ,RET>
    {
        T GetbyId(ID obj);
        RET GetAll( );
        void Create(T obj);
        bool Update(T id);
        bool Delete(ID id);
        
    }
}
