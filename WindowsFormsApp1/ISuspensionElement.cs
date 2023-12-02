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

        

        




    }
}
