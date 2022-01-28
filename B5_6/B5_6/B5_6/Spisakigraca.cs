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
    public partial class Spisakigraca : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B5_6;Integrated Security=True");
        public Spisakigraca()
        {
            InitializeComponent();
            SqlCommand grad = new SqlCommand("select distinct Grad from Grad order by Grad",conn);
            SqlCommand poz = new SqlCommand("select Naziv from Pozicija_igraca", conn);
            conn.Open();
            SqlDataReader rd = grad.ExecuteReader();
            while(rd.Read())
            {
                comboBox1.Items.Add(rd.GetString(0));
            }
            conn.Close();

            conn.Open();
            SqlDataReader rd1 = poz.ExecuteReader();
            while (rd1.Read())
            {
                comboBox2.Items.Add(rd1.GetString(0));
            }
            conn.Close();

            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Prikazi_btn_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Ime");
            dt.Columns.Add("Prezime");
            dt.Columns.Add("Naziv kluba");
            dt.Columns.Add("Grad");
            dt.Columns.Add("Naziv");

            SqlCommand Prikaz = new SqlCommand("select Igrac.Ime, Igrac.Prezime,Klub.NazivKluba,Grad.Grad,Pozicija_igraca.Naziv from Igrac join Klub on Igrac.KlubID=Klub.KlubID join Pozicija_igraca on Pozicija_igraca.PozicijaID = Igrac.PozicijaID join Grad on Klub.GradID = Grad.GradID where Grad=@p1 and Naziv=@p2 order by Ime,Prezime, NazivKluba desc", conn);
            Prikaz.Parameters.AddWithValue("@p1", comboBox1.Text);
            Prikaz.Parameters.AddWithValue("@p2", comboBox2.Text);
            conn.Open();
            SqlDataReader rd = Prikaz.ExecuteReader();
            while (rd.Read())
            {
                DataRow row = dt.NewRow();
                row["Ime"] = rd["Ime"];
                row["Prezime"] = rd["Prezime"];
                row["Naziv kluba"] = rd["NazivKluba"];
                row["Grad"] = rd["Grad"];
                row["Naziv"] = rd["Naziv"];
                dt.Rows.Add(row);
            }
            dataGridView1.DataSource = dt;

            
            conn.Close();
        }
    }
}
