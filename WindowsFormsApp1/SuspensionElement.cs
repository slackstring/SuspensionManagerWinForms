using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class SuspensionElement : ISuspensionElement
    {
        //properties
        public int Length { get; set; }
        public int Stroke { get; set; }
        public string SuspensionTyp { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public string DamperOil { get; set; }
        public int LscClicks { get; set; }
        public int HscClicks { get; set; }
        public int HsrClicks { get; set; }
        public int LsrClicks { get; set; }

    }
}
