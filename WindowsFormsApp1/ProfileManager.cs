using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApp1
{
    internal class ProfileManager
    {
        // properties
        public static Profile CurrentProfile { get; set; }


        //Methoden
        public static void CreateProfil(string profileName)
        {
            Profile profile = new Profile(profileName);
            //SaveProfile(profile);
        }

        public static void LoadProfile(string profileName)
        {

        }

        public static void SaveProfile(Profile profile)
        {
            string path = AppContext.BaseDirectory + profile.ProfileName + ".smp";
            //TODO saveprofile schreiben
        }
       
    }
}
