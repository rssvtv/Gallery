using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.SqlClient;

namespace Kino
{
    public partial class Form20 : Form
    {
        private int bilet = 0;
        public Form20(int bilet)
        {
            InitializeComponent();
            printButton.Text = "Print Form";
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            this.bilet = bilet;
        }
        string Connection = System.Configuration.ConfigurationManager.ConnectionStrings["Kino.Properties.Settings.kinoConnectionString"].ConnectionString;

        private Button printButton = new Button();
        private PrintDocument printDocument1 = new PrintDocument();
        private void Form20_Load(object sender, EventArgs e)
        {
            string sql = "SELECT Билет.*, Зал.Название FROM Билет INNER JOIN Сеанс ON Билет.Сеанс = Сеанс.Код INNER JOIN Зал ON Сеанс.Номер_зала = Зал.Номер  where Билет.Код = " + this.bilet;

            using (SqlConnection c = new SqlConnection(Connection))
            {
                c.Open();
                using (SqlDataAdapter a = new SqlDataAdapter(sql, c))
                {
                    DataTable t = new DataTable();
                    a.Fill(t);
                    label3.Text = t.Rows[0]["Дата_время"].ToString();
                    label2.Text = t.Rows[0]["Фильм"].ToString();
                    label8.Text = "Зал : " + t.Rows[0]["Название"].ToString();
                    label7.Text = "Стоимость билета : " + t.Rows[0]["Цена"].ToString();

                }
            }
        }
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height - 20, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void printDocument1_PrintPage(System.Object sender,
          System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lineShape1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
