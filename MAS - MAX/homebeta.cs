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
    public partial class homebeta : Form
    {
        public homebeta()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            anime dd = new anime();
            dd.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            helpi dd = new helpi();
            dd.ShowDialog();
            this.Close();
        }
    }
}
