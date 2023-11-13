using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeploobmenLibrary
{
    public class TeploobmenInputData
    {
        public int RasH { get; set; }
        public int RasTm { get; set; }
        public int RasTg { get; set; }
        public float RasV { get; set; }
        public float RasTemG { get; set; }
        public float RasRas { get; set; }
        public float RasTemM { get; set; }
        public int RasTepl { get; set; }
        public float RasD { get; set; }
        public float M { get; set; }
        public float Y0 { get; set; }
        public float Y1 { get; set; }
        public float Y1_DOP { get; set; }
    }
}
