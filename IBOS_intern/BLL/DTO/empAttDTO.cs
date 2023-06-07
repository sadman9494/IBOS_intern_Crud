using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
   public class empAttDTO
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public bool present { get; set; }
        public bool absent { get; set; }
        public bool offday { get; set; }

        public int eId { get; set; }
         public empDTO employees { get; set; }

     
    }
}
