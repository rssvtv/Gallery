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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
                      this.персоналTableAdapter.Fill(this.kinoDataSet.Персонал);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty && textBox3.Text != String.Empty )
            {
                 персоналTableAdapter.Insert(textBox1.Text, textBox2.Text, textBox3.Text);
                MessageBox.Show("Добавлено!");
                Close();
            }
            else
                MessageBox.Show("Не все поля были заполнены!");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char t = e.KeyChar;
            if (!char.IsControl(t) && !char.IsDigit(t))
            {
                e.Handled = true;

            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
