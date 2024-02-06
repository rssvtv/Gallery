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
    public partial class Form16 : Form
    { 
        public Form16()
        {
            InitializeComponent(); 
        }

        private void Form16_Load(object sender, EventArgs e)
        {
            this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);
          
        }

        private void пользовательBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.пользовательBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != String.Empty && textBox2.Text != String.Empty)
            {
                пользовательTableAdapter.Insert(textBox1.Text, textBox2.Text);
                MessageBox.Show("Добавлено!");
                Close();
            }
            else
                MessageBox.Show("Не все поля были заполнены!");
        }
    }
}
