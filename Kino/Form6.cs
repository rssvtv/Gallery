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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void залBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.залBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.залTableAdapter.Fill(this.kinoDataSet.Зал);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 x = new Form7();
            x.ShowDialog();
            this.залTableAdapter.Fill(this.kinoDataSet.Зал);
        }

        private void залDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
