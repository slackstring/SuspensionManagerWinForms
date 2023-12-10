using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    internal class SuspensionElement : ISuspensionElement
    {
        //properties
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int ModelYear { get; set; }
        public int Length { get; set; }
        public int Stroke { get; set; }
        public string SuspensionTyp { get; set; }    
        public List<Setting> Settings { get; set; }

         //Konstruktor
         public SuspensionElement(string manufacturer, string model, int modelYear, int length, int stroke, string suspensionTyp) 
        { 
            Manufacturer = manufacturer;
            Model = model;
            ModelYear = modelYear;
            Length = length;
            Stroke = stroke;
            SuspensionTyp = suspensionTyp;
        }


    }
}
