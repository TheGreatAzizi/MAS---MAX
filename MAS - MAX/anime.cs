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
    public partial class anime : Form
    {
        public anime()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 jj = new Form1();
            jj.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 jjj = new Form2();
            jjj.Show();
            this.Close();
        }
    }
}
