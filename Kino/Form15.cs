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
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void сеансBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сеансBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form15_Load(object sender, EventArgs e)
        {
            this.сеансTableAdapter.Fill(this.kinoDataSet.Сеанс);

        }

        private void сеансDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
