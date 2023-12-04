using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace WindowsFormsApp1
{
    [Serializable]
    internal class ProfileManager
    {
        // properties
        public static Profile CurrentProfile { get; set; }


        //Methoden
        public static void CreateProfil(string profileName)
        {
            Profile profile = new Profile(profileName);
            SaveProfile(profile);
        }

        public static void LoadProfile(string profileName)
        {
            string path = AppContext.BaseDirectory + profileName + ".smp";
            using (FileStream fileStream = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                CurrentProfile = binaryFormatter.Deserialize(fileStream) as Profile;
            }
        }

        public static void SaveProfile(Profile profile)
        {
            string path = AppContext.BaseDirectory + profile.ProfileName + ".smp";
            using (FileStream fileStream = new FileStream(path, FileMode.Create))
            {
                //FileStream fileStream = new FileStream(path, FileMode.Create);
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, profile);
            }
        }

        public static bool CheckIfProfileExists(string profileName)
        {
            FileInfo fileInfo = new FileInfo(AppContext.BaseDirectory + profileName + ".smp");
            return fileInfo.Exists;
        }

        public static string[] ShowProfiles()
        {
            string path = AppContext.BaseDirectory;
            string[] profileFiles = Directory.GetFiles(path, "*.smp");
            for(int i=0; i<profileFiles.Length; i++)
            {
                profileFiles[i] = Path.GetFileName(profileFiles[i]);
            }
            return profileFiles;
        }
       
    }
}
