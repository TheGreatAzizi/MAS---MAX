using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MAS___MAX
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anime dd = new anime();
            dd.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helpi dd = new helpi();
            dd.ShowDialog();
        }

        private void MASMax_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                DialogResult result = MessageBox.Show("Do you want to close the program?", ":(", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (result == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }

        private void MASMax_DoubleClick(object sender, EventArgs e)
        {
            homebeta dd = new homebeta();
            dd.Show();
        }
    }
}
