using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ProfileLoadMenu : Form
    {
        public ProfileLoadMenu()
        {
            InitializeComponent();
            RefreshListbox();
            //TODO OneNote mit der letzten Session füllen 
            //TODO Listbox grafisch bearbeiten
            //profile Laden implementieren
        }

        private void btnProfileLoadMenu_Click(object sender, EventArgs e)
        {
            string userInput = tbProfileLoadMenu_Create.Text.ToLower();
            if (!ProfileManager.CheckIfProfileExists(userInput))
            {
                ProfileManager.CreateProfil(userInput);
                RefreshListbox();
            }
            else
            {
                MessageBox.Show("There's already a profile existing with the choosen name!");
            }
            
        }

        private void RefreshListbox()
        {
            string[] profileFiles = ProfileManager.ShowProfiles();
            if (profileFiles.Count() > 0)
            {
                lbProfileLoadMenu_profiles.Items.Clear();
                lbProfileLoadMenu_profiles.Items.AddRange(profileFiles);
            }
        }
    }
}
