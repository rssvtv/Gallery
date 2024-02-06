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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            this.пользовательTableAdapter.Fill(this.kinoDataSet.Пользователь);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
          if (textBox1.Text != "")
            {
                if (textBox1.Text == ((DataRowView)пользовательBindingSource.Current).Row["Пароль"].ToString())
                {
                    if (comboBox1.Text == "Администратор")
                    {
                        Form2 x = new Form2();
                        x.ShowDialog();
                    }
                    else 
                    {
                        Form19 x = new Form19();
                        x.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Пароль неверный");
                }
            }
            else
            {
                MessageBox.Show("Введите пароль");
            } 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
