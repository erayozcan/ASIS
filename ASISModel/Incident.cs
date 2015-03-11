using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASIS.Model
{
    public class Incident
    {
        public int Id { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
        public string Message{ get; set; }
        public byte[] Image { get; set; }
        public byte[] Audio { get; set; }
        public double XCoordinate { get; set; }
        public double YCoordinate { get; set; }
        public DateTime CreatedDate { get; set; }
        public int State { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
    }
}
