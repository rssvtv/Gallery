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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void билетBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.билетBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinoDataSet);

        }

        private void Form17_Load(object sender, EventArgs e)
        {
            this.залTableAdapter.Fill(this.kinoDataSet.Зал);
            this.билетTableAdapter.Fill(this.kinoDataSet.Билет);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form18 x = new Form18();
            x.ShowDialog();
        }
        string Connection = System.Configuration.ConfigurationManager.ConnectionStrings["Kino.Properties.Settings.kinoConnectionString"].ConnectionString;
      
        private void button2_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(билетDataGridView.CurrentRow.Cells["dataGridViewTextBoxColumn1"].Value);
            try
            {
                using (SqlConnection con = new SqlConnection(Connection))
                {
                    con.Open();
                    using (SqlCommand command = new SqlCommand("Delete from Билет where Код=" + id, con))
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Билет возвращен");
                        this.билетTableAdapter.Fill(this.kinoDataSet.Билет);
                    }
                    con.Close();
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
            }
         
        }
    }
}
