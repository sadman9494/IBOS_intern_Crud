using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO

{
    public class empDTO
    {
        public int Id { get; set; }
        public string eName { get; set; }
        public string code { get; set; }
        public double salary { get; set; }

        public List<empAttDTO> attendence { get; set; }
        public empDTO()
        {
            this.attendence = new List<empAttDTO>();
        }

    
    }
}
