using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class AirShock : SuspensionElement 
    {
        public int AirPressure { get; set; }
        public int IfpPressure { get; set; }
        public float NPosToken { get; set; }
        public float NNegToken { get; set; }
        public string LubGrease { get; set; }
        public string LubOil { get; set; }
    }
}
