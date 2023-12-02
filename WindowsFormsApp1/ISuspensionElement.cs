using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal interface ISuspensionElement
    {
        //properties
        int Length { get; set; }
        int Stroke { get; set; }
        string SuspensionTyp { get; set; }
        string Manufacturer { get; set; }
        string Model { get; set; }
        int ModelYear { get; set; }
        string DamperOil { get; set; }
        int LscClicks { get; set; }
        int HscClicks { get; set; }
        int HsrClicks { get; set; }
        int LsrClicks { get; set; }
        


    }
}
