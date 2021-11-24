using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Индивидуальное
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 frm = new Form4();
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form5 frm = new Form5();
            frm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 frm = new Form6();
            frm.ShowDialog();
        }
    }
}
