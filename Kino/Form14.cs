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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void сеансBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сеансBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);
            this.залTableAdapter.Fill(this.kinoDataSet.Зал);
            this.сеансTableAdapter.Fill(this.kinoDataSet.Сеанс);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        { 
                сеансTableAdapter.Insert(dateTimePicker1.Value, Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue),  Convert.ToInt32(((DataRowView)залBindingSource.Current).Row["Всего_мест"].ToString()), Convert.ToInt32(numericUpDown2.Value));
                MessageBox.Show("Добавлено!");
                Close();
        }
    }
}
