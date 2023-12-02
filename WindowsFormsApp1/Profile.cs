using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Profile
    {
        //properties
        public string ProfileName { get; private set; }
        public List<SuspensionElement> SuspensionElements { get; set; }

        // Konstruktor
        public Profile(string profileName)
        {
            ProfileName = profileName;
        }
    }
}
