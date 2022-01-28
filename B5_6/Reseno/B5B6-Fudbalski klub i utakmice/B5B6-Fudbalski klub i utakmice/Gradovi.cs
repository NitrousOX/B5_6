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

namespace B5B6_Fudbalski_klub_i_utakmice
{
    public partial class Gradovi : Form
    {
        SqlConnection baza = new SqlConnection(@"Data Source=DESKTOP-DN69ACH;Initial Catalog=B5_6;Integrated Security=True");
        public Gradovi()
        {
            InitializeComponent();
        }

        private void Gradovi_Load(object sender, EventArgs e)
        {

        }

        private void btUpisi_Click(object sender, EventArgs e)
        {
            try
            {
                if (sifraTbx.Text == "")
                    throw new Exception("Niste upisali sifru!");
                else if (gradTbx.Text == "")
                    throw new Exception("Niste upisali grad!");
                else if (pozivniBrojTbx.Text == "")
                    throw new Exception("Niste upisali pozivni broj!");
                else if (postanskiBrojTbx.Text == "")
                    throw new Exception("Niste upisali postanski broj!");
                else if (BrojStanovnikaTbx.Text == "")
                    throw new Exception("Niste upisali broj stanovnika!");

else
                {
                    SqlCommand insert = new SqlCommand("insert into Grad values(@p1,@p2,@p3,@p4,@p5)", baza);
                    insert.Parameters.AddWithValue("@p1", sifraTbx.Text);
                    insert.Parameters.AddWithValue("@p2", gradTbx.Text);

insert.Parameters.AddWithValue("@p3", pozivniBrojTbx.Text);
                    insert.Parameters.AddWithValue("@p4", postanskiBrojTbx.Text);
                    insert.Parameters.AddWithValue("@p5", BrojStanovnikaTbx.Text);
                    baza.Open();
                    insert.ExecuteNonQuery();

           }}
                

        
              catch (SqlException ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Ovaj grad vec postoji!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                baza.Close();
            }}
            private void btNovi_Click(object sender, EventArgs e)
        { 
                sifraTbx.ResetText();
            gradTbx.ResetText();
            pozivniBrojTbx.ResetText(); 
                postanskiBrojTbx.ResetText();
            BrojStanovnikaTbx.ResetText();
            sifraTbx.Focus();
        }

            private void btIzadji_Click(object sender, EventArgs e)
            {
                this.Close();
            }

  

        }}

        
    

    

