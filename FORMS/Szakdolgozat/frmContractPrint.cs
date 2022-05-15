using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szakdolgozat
{
    public partial class frmContractPrint : Form
    {
        static string ConnectionString;
        public int Id;
        public List<string> Car = new List<string>();
        public frmContractPrint()
        {
            InitializeComponent();
        }
        private void frmContractPrint_Load(object sender, EventArgs e)
        {
            SetColor();
        }


        private void SetColor()
        {
            this.BackColor = Properties.Settings.Default.ColorBack;
            this.ForeColor = Properties.Settings.Default.ColorFore;
            this.btnCancel.BackColor = Properties.Settings.Default.ColorButton;
            this.btnCancel.BackColor = Properties.Settings.Default.ColorButton;
            this.btnPrint.BackColor = Properties.Settings.Default.ColorButton;
            this.btnPrint.BackColor = Properties.Settings.Default.ColorButton;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
