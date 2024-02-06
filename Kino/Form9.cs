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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kinoDataSet.Персонал". При необходимости она может быть перемещена или удалена.
            this.персоналTableAdapter.Fill(this.kinoDataSet.Персонал);

        }
    }
}
