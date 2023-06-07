using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.DTO;
using DAL;

namespace BLL.Services
{
    public class attServices
    {
        public static List<empAttDTO> Report()
        {
            var att = new List<empAttDTO>();
            var attdb = DataAccessFactory.AttDataAccess().GetAll();
            foreach (var attendence in attdb)
            {
                att.Add(new empAttDTO()
                {
                    Id = attendence.Id,
                    date = attendence.date,
                    present = attendence.present,
                    absent = attendence.absent,
                    offday = attendence.offday,
                    
                }) ;

            }
            return att;
        }

        public static List<empAttDTO> absentlist()
        {
            var att = new List<empAttDTO>();
            var attdb = DataAccessFactory.AttDataAccess().GetAll();
            foreach (var attendence in attdb)
            {
                if (Convert.ToInt32(attendence.absent) >= 1)
                {
                    att.Add(new empAttDTO()
                    {
                        Id = attendence.Id,
                        date = attendence.date,
                        present = attendence.present,
                        absent = attendence.absent,
                        offday = attendence.offday
                        
                    });
                }
            }
            return att;
        }


    }
}
