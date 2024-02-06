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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form12_Load(object sender, EventArgs e)
        {
                     this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);

        }

        private void пользовательDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
