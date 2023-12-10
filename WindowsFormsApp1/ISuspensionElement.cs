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
        string Manufacturer { get; set; }
        string Model { get; set; }
        int ModelYear { get; set; }
        int Length { get; set; }
        int Stroke { get; set; }
        string SuspensionTyp { get; set; }          
        List<Setting> Settings { get; set; }
    }
}
