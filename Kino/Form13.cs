using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Kino
{
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void сеансBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сеансBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form13_Load(object sender, EventArgs e)
        {
            this.билетTableAdapter.Fill(this.kinoDataSet.Билет);
            this.залTableAdapter.Fill(this.kinoDataSet.Зал);
            this.фильмTableAdapter.Fill(this.kinoDataSet.Фильм);
            this.сеансTableAdapter.Fill(this.kinoDataSet.Сеанс);
            if (сеансDataGridView.Rows.Count > 0)
            {
                                  

 this.билетBindingSource.Filter = "Номер_зала = " + Convert.ToInt32(сеансDataGridView.CurrentRow.Cells["Номер_зала"].Value.ToString()) + " and Фильм = '"
     + Convert.ToString((сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"] as DataGridViewComboBoxCell).FormattedValue.ToString()) + 
                    "' and Дата_время = '"+ Convert.ToString(сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString())
                    + "'";
 numericUpDown1.Maximum = Convert.ToInt32((сеансDataGridView.CurrentRow.Cells["Мест"] as DataGridViewComboBoxCell).FormattedValue.ToString());
 numericUpDown2.Maximum = Convert.ToInt32((сеансDataGridView.CurrentRow.Cells["Рядов"] as DataGridViewComboBoxCell).FormattedValue.ToString());
            }
            comboBox3.Visible = false;
            comboBox2.Visible = false;
            dateTimePicker1.Visible = false;
            dateTimePicker2.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
        }

        private void сеансDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {               

            this.билетBindingSource.Filter = "Номер_зала = " + Convert.ToInt32(сеансDataGridView.CurrentRow.Cells["Номер_зала"].Value.ToString()) + " and Фильм = '"
       + Convert.ToString((сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"] as DataGridViewComboBoxCell).FormattedValue.ToString()) +
                      "' and Дата_время = '" + Convert.ToString(сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString())
                      + "'";
            numericUpDown1.Maximum = Convert.ToInt32((сеансDataGridView.CurrentRow.Cells["Мест"] as DataGridViewComboBoxCell).FormattedValue.ToString());
            numericUpDown2.Maximum = Convert.ToInt32((сеансDataGridView.CurrentRow.Cells["Рядов"] as DataGridViewComboBoxCell).FormattedValue.ToString());
     
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form14 x = new Form14();
            x.ShowDialog();
            this.сеансTableAdapter.Fill(this.kinoDataSet.Сеанс);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                dateTimePicker1.Visible = true;
                dateTimePicker2.Visible = true;
                label6.Visible = true;
                label5.Visible = true;
            }
            else
            { 
                dateTimePicker1.Visible = false;
                dateTimePicker2.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                comboBox2.Visible = true;
            }
            else
                comboBox2.Visible = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                comboBox3.Visible = true;
            }
            else
                comboBox3.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.сеансBindingSource.Filter = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string filter = "Код = Код "; 
            bool error = false;
            if (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked) 
            {
                if (checkBox1.Checked)
                {
                    filter += String.Format("and Дата_время >= '{0:yyyy-MM-dd}' AND Дата_время < '{1:yyyy-MM-dd}'", dateTimePicker1.Value.ToShortDateString(), dateTimePicker2.Value.AddDays(1).ToShortDateString());
                }
                if (checkBox3.Checked)
                {
                        filter += " and Номер_зала = " + comboBox2.SelectedValue + " ";
                                   }
                if (checkBox2.Checked)
                {
                  
                        filter += " and Фильм = " + comboBox3.SelectedValue + " ";
                }

                if (error)
                {
                    MessageBox.Show("Заполните поле поиска для выбранного критерия!");
                    return;
                }
                else
                {
                    this.сеансBindingSource.Filter = filter; 
                }

            }
            else
                MessageBox.Show("Выберите хотя бы один критерий поиска!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form15 x = new Form15();
            x.ShowDialog();
            this.сеансTableAdapter.Fill(this.kinoDataSet.Сеанс);
        }

        private void button3_Click(object sender, EventArgs e)
        {  
        }

        string Connection = System.Configuration.ConfigurationManager.ConnectionStrings["Kino.Properties.Settings.kinoConnectionString"].ConnectionString;

        private void printBilet(int bilet)
        {
            Form20 x = new Form20(bilet);
            x.ShowDialog();
        }

        private void addBilet(bool bronirovanie)
        {
            if (билетDataGridView.RowCount > 0)
            {
                for (int i = 0; i < билетDataGridView.RowCount; i++)
                {
                    if (Convert.ToInt32(билетDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn15"].Value) == Convert.ToInt32(numericUpDown2.Value) &&
                        Convert.ToInt32(билетDataGridView.Rows[i].Cells["dataGridViewTextBoxColumn12"].Value) == Convert.ToInt32(numericUpDown1.Value))
                    {
                        MessageBox.Show("Это место уже занято");
                        return;
                    }
                }
            }
            byte kuplen = 1;
            билетTableAdapter.Insert(Convert.ToDateTime(сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn2"].Value.ToString()), Convert.ToInt32(сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString()), Convert.ToString((сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn4"] as DataGridViewComboBoxCell).FormattedValue.ToString()), Convert.ToInt32(сеансDataGridView.CurrentRow.Cells["Номер_зала"].Value.ToString()), Convert.ToInt32(numericUpDown1.Value), kuplen, Convert.ToInt32(сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn6"].Value.ToString()), Convert.ToInt32(numericUpDown2.Value));
            string new_id = "";
            string sql = "SELECT top 1 * from Билет order by Код DESC";
            using (SqlConnection c = new SqlConnection(Connection))
            {
                c.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(sql, c))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    new_id = t.Rows[0]["Код"].ToString();
                }
            }
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("Update Сеанс set Места = Места-1 where Код=" + сеансDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value.ToString(), con))
                    {
                        command.ExecuteNonQuery();
                    }
                    this.сеансTableAdapter.Fill(this.kinoDataSet.Сеанс);
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
            {
                MessageBox.Show("Билет успешно продан");
                printBilet(Convert.ToInt32(new_id));
            }

            this.билетTableAdapter.Fill(this.kinoDataSet.Билет);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addBilet(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void сеансDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void билетDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
