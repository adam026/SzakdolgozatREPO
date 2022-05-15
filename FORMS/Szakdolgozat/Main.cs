using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;


namespace Szakdolgozat
{
    public partial class formMain : Form
    {
        static public string ConnectionString;
        private Form activeForm = null;
        public string EncryptDecrypt(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }
        private void formMain_Load(object sender, EventArgs e)
        {
            SetColor();
            if (Properties.Settings.Default.PasswordValid == false) Application.Exit();
            else this.Show();
        }
        public formMain()
        {
            InitializeComponent();
            Properties.Settings.Default.ConnectionName = "frankieh_frankie";
            Properties.Settings.Default.ConnectionPassword = "ml1510domain";
            ConnectionString = $"Server = frankie75.hu; Database = frankieh_autokolcsonzo; Uid = {Properties.Settings.Default.ConnectionName}; Pwd = {Properties.Settings.Default.ConnectionPassword}; convert zero datetime=True";

            frmLogin f = new frmLogin(ConnectionString);
            f.ShowDialog();
        }
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlForm.Controls.Add(childForm);
            pnlForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void kilepesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExit());
        }

        private void felhasznaloAdminisztracioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUserAdmin(ConnectionString));
        }

        private void ugyfeltorzsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCustomerAdmin(ConnectionString));
        }

        private void eszkozokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDevicesAdmin(ConnectionString));
        }

        private void ujSzerzodesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new frmNewContract(ConnectionString);
            f.ShowDialog();
        }
        private void btsSettings_Click(object sender, EventArgs e)
        {
            frmSettings f = new frmSettings();
            f.ShowDialog();
            SetColor();
        }
        private void btnCont_Click(object sender, EventArgs e)
        {
            openChildForm(new frmContract(ConnectionString));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            openChildForm(new frmExit());
        }
        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            
            this.btnCustomers.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCustomers.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnExit.BackColor = Properties.Settings.Default.ColorButton;
            this.btnExit.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnUsers.BackColor = Properties.Settings.Default.ColorButton;
            this.btnUsers.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnVehicles.BackColor = Properties.Settings.Default.ColorButton;
            this.btnVehicles.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnSettings.BackColor = Properties.Settings.Default.ColorButton;
            this.btnSettings.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnCont.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCont.ForeColor = Properties.Settings.Default.ColorFore;
        }
        private void lbWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://carrent-all.azurewebsites.net/");
        }
    }
}
