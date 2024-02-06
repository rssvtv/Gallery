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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 x = new Form12();
            x.ShowDialog();
            this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form16 x = new Form16();
            x.ShowDialog();
            this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);
        }

        private void пользовательDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
