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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form18_Load(object sender, EventArgs e)
        {
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);
            this.билетTableAdapter.Fill(this.kinoDataSet.Билет);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void билетDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
