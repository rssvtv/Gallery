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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void персоналBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.персоналBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form8_Load(object sender, EventArgs e)
        {
            this.персоналTableAdapter.Fill(this.kinoDataSet.Персонал);
            textBox1.Visible = false;
            textBox4.Visible = false;
            textBox3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filter = "Код = Код ";
            bool error = false;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked)
            {
                if (checkBox1.Checked)
                {
                    if (textBox3.Text != "")
                    {
                        filter += " and ФИО like '%" + textBox3.Text + "%' ";
                    }
                    else
                    {
                        error = true;
                    }
                }
                if (checkBox3.Checked)
                {
                    if (textBox4.Text != "")
                    {
                        filter += " and Должность like '%" + textBox4.Text + "%' ";
                    }
                    else
                    {
                        error = true;
                    }
                }
                if (checkBox2.Checked)
                {
                    if (textBox1.Text != "")
                    {
                        filter += " and Телефон like '%" + textBox1.Text + "%' ";
                    }
                    else
                    {
                        error = true;
                    }
                }

                if (error)
                {
                    MessageBox.Show("Заполните поле поиска для выбранного критерия!");
                    return;
                }
                else
                {
                    this.персоналBindingSource.Filter = filter; 
                }

            }
            else
                MessageBox.Show("Выберите хотя бы один критерий поиска!");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox3.Visible = true;
                textBox3.Text = String.Empty;
            }
            else
                textBox3.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox4.Visible = true;
                textBox4.Text = String.Empty;
            }
            else
                textBox4.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox1.Visible = true;
                textBox1.Text = String.Empty;
            }
            else
                textBox1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.персоналBindingSource.Filter = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false; 
            checkBox3.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 x = new Form9();
            x.ShowDialog();
            this.персоналTableAdapter.Fill(this.kinoDataSet.Персонал);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 x = new Form10();
            x.ShowDialog();
            this.персоналTableAdapter.Fill(this.kinoDataSet.Персонал);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
