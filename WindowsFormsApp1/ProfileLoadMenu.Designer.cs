namespace WindowsFormsApp1
{
    partial class ProfileLoadMenu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileLoadMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.tbProfileLoadMenu_Create = new System.Windows.Forms.TextBox();
            this.btnProfileLoadMenu = new System.Windows.Forms.Button();
            this.btnProfileLoadMenu_Load = new System.Windows.Forms.Button();
            this.lbProfileLoadMenu_profiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto Lt", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(347, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(619, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose existing profile or create a new profile!";
            // 
            // tbProfileLoadMenu_Create
            // 
            this.tbProfileLoadMenu_Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbProfileLoadMenu_Create.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.tbProfileLoadMenu_Create.Location = new System.Drawing.Point(560, 121);
            this.tbProfileLoadMenu_Create.Name = "tbProfileLoadMenu_Create";
            this.tbProfileLoadMenu_Create.Size = new System.Drawing.Size(227, 20);
            this.tbProfileLoadMenu_Create.TabIndex = 2;
            this.tbProfileLoadMenu_Create.Text = "profile name";
            // 
            // btnProfileLoadMenu
            // 
            this.btnProfileLoadMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfileLoadMenu.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnProfileLoadMenu.FlatAppearance.BorderSize = 2;
            this.btnProfileLoadMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileLoadMenu.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnProfileLoadMenu.Location = new System.Drawing.Point(560, 160);
            this.btnProfileLoadMenu.Name = "btnProfileLoadMenu";
            this.btnProfileLoadMenu.Size = new System.Drawing.Size(227, 23);
            this.btnProfileLoadMenu.TabIndex = 3;
            this.btnProfileLoadMenu.Text = "create profile";
            this.btnProfileLoadMenu.UseVisualStyleBackColor = false;
            this.btnProfileLoadMenu.Click += new System.EventHandler(this.btnProfileLoadMenu_Click);
            // 
            // btnProfileLoadMenu_Load
            // 
            this.btnProfileLoadMenu_Load.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnProfileLoadMenu_Load.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnProfileLoadMenu_Load.FlatAppearance.BorderSize = 2;
            this.btnProfileLoadMenu_Load.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfileLoadMenu_Load.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnProfileLoadMenu_Load.Location = new System.Drawing.Point(560, 468);
            this.btnProfileLoadMenu_Load.Name = "btnProfileLoadMenu_Load";
            this.btnProfileLoadMenu_Load.Size = new System.Drawing.Size(227, 42);
            this.btnProfileLoadMenu_Load.TabIndex = 4;
            this.btnProfileLoadMenu_Load.Text = "load profile";
            this.btnProfileLoadMenu_Load.UseVisualStyleBackColor = false;
            // 
            // lbProfileLoadMenu_profiles
            // 
            this.lbProfileLoadMenu_profiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbProfileLoadMenu_profiles.FormattingEnabled = true;
            this.lbProfileLoadMenu_profiles.Location = new System.Drawing.Point(322, 121);
            this.lbProfileLoadMenu_profiles.Name = "lbProfileLoadMenu_profiles";
            this.lbProfileLoadMenu_profiles.Size = new System.Drawing.Size(200, 355);
            this.lbProfileLoadMenu_profiles.TabIndex = 5;
            // 
            // ProfileLoadMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.lbProfileLoadMenu_profiles);
            this.Controls.Add(this.btnProfileLoadMenu_Load);
            this.Controls.Add(this.btnProfileLoadMenu);
            this.Controls.Add(this.tbProfileLoadMenu_Create);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileLoadMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuspensionManager: Choose Profile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProfileLoadMenu_Create;
        private System.Windows.Forms.Button btnProfileLoadMenu;
        private System.Windows.Forms.Button btnProfileLoadMenu_Load;
        private System.Windows.Forms.ListBox lbProfileLoadMenu_profiles;
    }
}

