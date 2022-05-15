namespace Szakdolgozat
{
    partial class formMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kilepesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ujSzerzodesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ugyfeltorzsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszkozokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.felhasznaloAdminisztracioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.beallitasokToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilepesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnUsers = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lbWeb = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnCont = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnVehicles = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kilepesToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.beallitasokToolStripMenuItem,
            this.kilepesToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(276, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1098, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kilepesToolStripMenuItem
            // 
            this.kilepesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ujSzerzodesToolStripMenuItem});
            this.kilepesToolStripMenuItem.Name = "kilepesToolStripMenuItem";
            this.kilepesToolStripMenuItem.Size = new System.Drawing.Size(82, 22);
            this.kilepesToolStripMenuItem.Text = "Szerződések";
            // 
            // ujSzerzodesToolStripMenuItem
            // 
            this.ujSzerzodesToolStripMenuItem.Name = "ujSzerzodesToolStripMenuItem";
            this.ujSzerzodesToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ujSzerzodesToolStripMenuItem.Text = "Új szerződés";
            this.ujSzerzodesToolStripMenuItem.Click += new System.EventHandler(this.ujSzerzodesToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ugyfeltorzsToolStripMenuItem,
            this.eszkozokToolStripMenuItem,
            this.felhasznaloAdminisztracioToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.adminToolStripMenuItem.Text = "Adminisztráció";
            // 
            // ugyfeltorzsToolStripMenuItem
            // 
            this.ugyfeltorzsToolStripMenuItem.Name = "ugyfeltorzsToolStripMenuItem";
            this.ugyfeltorzsToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.ugyfeltorzsToolStripMenuItem.Text = "Ügyfelek";
            this.ugyfeltorzsToolStripMenuItem.Click += new System.EventHandler(this.ugyfeltorzsToolStripMenuItem_Click);
            // 
            // eszkozokToolStripMenuItem
            // 
            this.eszkozokToolStripMenuItem.Name = "eszkozokToolStripMenuItem";
            this.eszkozokToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.eszkozokToolStripMenuItem.Text = "Gépjárművek";
            this.eszkozokToolStripMenuItem.Click += new System.EventHandler(this.eszkozokToolStripMenuItem_Click);
            // 
            // felhasznaloAdminisztracioToolStripMenuItem
            // 
            this.felhasznaloAdminisztracioToolStripMenuItem.Name = "felhasznaloAdminisztracioToolStripMenuItem";
            this.felhasznaloAdminisztracioToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.felhasznaloAdminisztracioToolStripMenuItem.Text = "Felhasználók";
            this.felhasznaloAdminisztracioToolStripMenuItem.Click += new System.EventHandler(this.felhasznaloAdminisztracioToolStripMenuItem_Click);
            // 
            // beallitasokToolStripMenuItem
            // 
            this.beallitasokToolStripMenuItem.Name = "beallitasokToolStripMenuItem";
            this.beallitasokToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.beallitasokToolStripMenuItem.Text = "Beállítások";
            this.beallitasokToolStripMenuItem.Click += new System.EventHandler(this.btsSettings_Click);
            // 
            // kilepesToolStripMenuItem1
            // 
            this.kilepesToolStripMenuItem1.Name = "kilepesToolStripMenuItem1";
            this.kilepesToolStripMenuItem1.Size = new System.Drawing.Size(56, 22);
            this.kilepesToolStripMenuItem1.Text = "Kilépés";
            this.kilepesToolStripMenuItem1.Click += new System.EventHandler(this.kilepesToolStripMenuItem1_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.BackColor = System.Drawing.Color.Transparent;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(276, 24);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(1098, 697);
            this.pnlForm.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "www.";
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.Color.Gray;
            this.btnCustomers.FlatAppearance.BorderSize = 2;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCustomers.ForeColor = System.Drawing.Color.Black;
            this.btnCustomers.Image = global::Szakdolgozat.Properties.Resources.ugyfel;
            this.btnCustomers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Location = new System.Drawing.Point(37, 402);
            this.btnCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(205, 48);
            this.btnCustomers.TabIndex = 10;
            this.btnCustomers.Text = "Ügyféltörzs";
            this.btnCustomers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.ugyfeltorzsToolStripMenuItem_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.Gray;
            this.btnSettings.FlatAppearance.BorderSize = 2;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSettings.ForeColor = System.Drawing.Color.Black;
            this.btnSettings.Image = global::Szakdolgozat.Properties.Resources.beallit;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(37, 556);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(205, 48);
            this.btnSettings.TabIndex = 13;
            this.btnSettings.Text = "Beállítások";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btsSettings_Click);
            // 
            // btnUsers
            // 
            this.btnUsers.BackColor = System.Drawing.Color.Gray;
            this.btnUsers.FlatAppearance.BorderSize = 2;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUsers.ForeColor = System.Drawing.Color.Black;
            this.btnUsers.Image = global::Szakdolgozat.Properties.Resources.felhasz;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(37, 489);
            this.btnUsers.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(205, 48);
            this.btnUsers.TabIndex = 12;
            this.btnUsers.Text = "Felhasználók";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = false;
            this.btnUsers.Click += new System.EventHandler(this.felhasznaloAdminisztracioToolStripMenuItem_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Gray;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = global::Szakdolgozat.Properties.Resources.kilep;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(37, 649);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(205, 48);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Kilépés";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lbWeb
            // 
            this.lbWeb.AutoSize = true;
            this.lbWeb.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWeb.ForeColor = System.Drawing.Color.White;
            this.lbWeb.Location = new System.Drawing.Point(12, 140);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Size = new System.Drawing.Size(240, 47);
            this.lbWeb.TabIndex = 7;
            this.lbWeb.Text = "Car-RentAll";
            this.lbWeb.Click += new System.EventHandler(this.lbWeb_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::Szakdolgozat.Properties.Resources.logo_kis;
            this.pbLogo.Location = new System.Drawing.Point(69, 27);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(142, 122);
            this.pbLogo.TabIndex = 6;
            this.pbLogo.TabStop = false;
            // 
            // btnCont
            // 
            this.btnCont.BackColor = System.Drawing.Color.Gray;
            this.btnCont.FlatAppearance.BorderSize = 2;
            this.btnCont.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnCont.ForeColor = System.Drawing.Color.Black;
            this.btnCont.Image = global::Szakdolgozat.Properties.Resources.nymomtat;
            this.btnCont.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCont.Location = new System.Drawing.Point(37, 272);
            this.btnCont.Margin = new System.Windows.Forms.Padding(2);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(205, 48);
            this.btnCont.TabIndex = 11;
            this.btnCont.Text = "Szerződések";
            this.btnCont.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCont.UseVisualStyleBackColor = false;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(243, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = ".com";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.Gray;
            this.pnlMenu.Controls.Add(this.label5);
            this.pnlMenu.Controls.Add(this.btnCont);
            this.pnlMenu.Controls.Add(this.pbLogo);
            this.pnlMenu.Controls.Add(this.lbWeb);
            this.pnlMenu.Controls.Add(this.btnExit);
            this.pnlMenu.Controls.Add(this.btnUsers);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnCustomers);
            this.pnlMenu.Controls.Add(this.btnVehicles);
            this.pnlMenu.Controls.Add(this.label4);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(276, 721);
            this.pnlMenu.TabIndex = 17;
            // 
            // btnVehicles
            // 
            this.btnVehicles.BackColor = System.Drawing.Color.Gray;
            this.btnVehicles.FlatAppearance.BorderSize = 2;
            this.btnVehicles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVehicles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnVehicles.ForeColor = System.Drawing.Color.Black;
            this.btnVehicles.Image = global::Szakdolgozat.Properties.Resources.gepjarmu;
            this.btnVehicles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVehicles.Location = new System.Drawing.Point(37, 337);
            this.btnVehicles.Margin = new System.Windows.Forms.Padding(2);
            this.btnVehicles.Name = "btnVehicles";
            this.btnVehicles.Size = new System.Drawing.Size(205, 48);
            this.btnVehicles.TabIndex = 11;
            this.btnVehicles.Text = "Gépjárművek listája";
            this.btnVehicles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVehicles.UseVisualStyleBackColor = false;
            this.btnVehicles.Click += new System.EventHandler(this.eszkozokToolStripMenuItem_Click);
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(1374, 721);
            this.ControlBox = false;
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarRent-All Ugyviteli rendszer";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem felhasznaloAdminisztracioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilepesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ujSzerzodesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ugyfeltorzsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszkozokToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beallitasokToolStripMenuItem;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnUsers;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lbWeb;
        internal System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnVehicles;
    }
}

