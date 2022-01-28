using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace B5_6
{
    public partial class kapacitet : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B5_6;Integrated Security=True");

        public kapacitet()
        {
            InitializeComponent();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prikazi_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrWhiteSpace(textBox1.Text))
                    throw new Exception("Morate uneti kapacitet");
                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!Char.IsDigit(textBox1.Text[i]))
                    {
                        textBox1.Text = null;
                        throw new Exception("Morate uneti broj");
                        
                    }
                }

                SqlCommand command = new SqlCommand("select Stadion.Naziv, Klub.NazivKluba, Klub.Sajt, Stadion.Kapacitet, Stadion.BrojUlaza from Stadion join Klub on Klub.StadionID = Stadion.StadionID where Stadion.Kapacitet > @p1 order by Stadion.Kapacitet asc ,Stadion.BrojUlaza desc;", conn);
                command.Parameters.AddWithValue("@p1", Convert.ToInt32(textBox1.Text));
                DataTable dt = new DataTable();
                dt.Columns.Add("Stadion");
                dt.Columns.Add("Klub");
                dt.Columns.Add("Sajt");
                dt.Columns.Add("Kapacitet");
                dt.Columns.Add("Broj ulaza");
                conn.Open();
                SqlDataReader rd = command.ExecuteReader();
                while(rd.Read())
                {
                    DataRow row = dt.NewRow();
                    row["Stadion"] = rd["Naziv"].ToString();
                    row["Klub"]= rd["NazivKluba"].ToString();
                    row["Sajt"]= rd["Sajt"].ToString();
                    row["Kapacitet"]= rd["Kapacitet"].ToString();
                    row["Broj ulaza"]= rd["BrojUlaza"].ToString();
                    dt.Rows.Add(row);
                }
                dataGridView1.DataSource = dt;

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
