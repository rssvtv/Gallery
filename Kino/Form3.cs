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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void фильмBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);
            if (фильмDataGridView.Rows.Count > 0)
            {
                textBox1.Text = фильмDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
            }
        }

        private void фильмDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = фильмDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 x = new Form4();
            x.ShowDialog();
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 x = new Form5();
            x.ShowDialog();
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
