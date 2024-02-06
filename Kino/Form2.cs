using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kino
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form6 x = new Form6();
            x.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Form8 x = new Form8();
            x.ShowDialog();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            Form11 x = new Form11();
            x.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Form13 x = new Form13();
            x.ShowDialog();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            Form17 x = new Form17();
            x.ShowDialog();
        }

        private void Button7_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {

        }

        private void Button10_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}