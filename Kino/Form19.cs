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
    public partial class Form19 : Form
    {
        public Form19()
        {
            InitializeComponent();
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

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form26_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Form3 x = new Form3();
            x.ShowDialog();

        }
    }
}