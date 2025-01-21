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
    public partial class helpi : Form
    {
        public helpi()
        {
            InitializeComponent();
        }
        private void helpi_Load(object sender, EventArgs e)
        {
        }

        private void hotkeys_Click(object sender, EventArgs e)
        {
            textBox1.Text = "There are a total of 7 hotkeys in the program.\r\nTo use these hotkeys, you must be on pages that have a quick access menu.\r\n-------------------\r\nHome: ctrl + h\r\nHelp: ctrl + i\r\n-------------------\r\nAnime search: ctrl + as\r\nTop 10 anime: ctrl + ak\r\n-------------------\r\nMovie and series search: ctrl + ms\r\nTop 10 series: ctrl + st\r\nTop 10 movies: ctrl + mt";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "In this section, which is located at the end of the anime search page, related animes, including other anime seasons or special episodes, are displayed with each search, and you can get their information by clicking on each of them.";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Note: If you are from Iran, be sure to use vpn to use this section.";
        }
    }
}
