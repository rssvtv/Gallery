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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void ФильмBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.фильмBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Bbutton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty && textBox4.Text != String.Empty && maskedTextBox1.Text != String.Empty)
            {
                фильмTableAdapter.Insert(textBox1.Text, textBox2.Text, Convert.ToInt32(numericUpDown1.Value),Convert.ToDouble(maskedTextBox1.Text),textBox3.Text, textBox4.Text, Convert.ToInt32(numericUpDown2.Value));
                MessageBox.Show("Добавлено!");
                Close();
            }
            else
                MessageBox.Show("Не все поля были заполнены!");
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}
