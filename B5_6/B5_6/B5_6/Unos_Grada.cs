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
    public partial class Unos_Grada : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B5_6;Integrated Security=True");
        List<Grad> lista = new List<Grad>();
        int brojac = 0;

        public Unos_Grada()
        {
            InitializeComponent();
            Ucitavanje_uListu();
            textBox1.Enabled = false;
            Upisi_btn.Enabled = false;
            Novi_btn.Select();
            if (brojac == 0)
            {
                prethodni_btn.Enabled = false;

            }

            textBox1.Text = lista[0].ID.ToString();
            textBox2.Text = lista[0].Grad_ime;
            textBox3.Text = lista[0].Poz;
            textBox4.Text = lista[0].Postanski.ToString();
            textBox5.Text = lista[0].Br.ToString();

        }

        public class Grad {
            private int id;
            private string grad;
            private string poz_broj;//max 4
            private int postanski;
            private int brstanovnika;

            public Grad(int id,string grad,string poz_broj,int postanski,int brstanovnika)
            {
                this.id = id;
                this.grad = grad;
                this.poz_broj = poz_broj;
                this.postanski = postanski;
                this.brstanovnika = brstanovnika;
            }
            public int ID{ get { return id; } }
            public string Grad_ime { get { return grad; } }
            public string Poz { get { return poz_broj; } }
            public int Postanski { get { return postanski; } }
            public int Br { get { return brstanovnika; } }


        }

        private void Izadji_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Ucitavanje_uListu()
        {
            lista.Clear();
            SqlCommand ucitavanje = new SqlCommand("select * from Grad",conn);
            conn.Open();
            SqlDataReader rd = ucitavanje.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new Grad(rd.GetInt32(0),rd.GetString(1), rd.GetString(2), rd.GetInt32(3), rd.GetInt32(4)));
            }
            conn.Close();
        }

        private void Sledeci_btn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            ++brojac;
            if (brojac == lista.Count - 1)
            {
                sledeci_btn.Enabled = false;
            }
            prethodni_btn.Enabled = true;

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = lista[lista.Count - 1].ID.ToString();
                textBox2.Text = lista[lista.Count - 1].Grad_ime;
                textBox3.Text = lista[lista.Count - 1].Poz;
                textBox4.Text = lista[lista.Count - 1].Postanski.ToString();
                textBox5.Text = lista[lista.Count - 1].Br.ToString();
                brojac=lista.Count-1;
                sledeci_btn.Enabled = false;
            }
            else
            {
                textBox1.Text = lista[brojac].ID.ToString();
                textBox2.Text = lista[brojac].Grad_ime;
                textBox3.Text = lista[brojac].Poz;
                textBox4.Text = lista[brojac].Postanski.ToString();
                textBox5.Text = lista[brojac].Br.ToString();
                
            }
        }

        private void Prethodni_btn_Click(object sender, EventArgs e)
        {
            --brojac;
            textBox1.Enabled = false;
            if (brojac == 0)
            {
                prethodni_btn.Enabled = false;

            }
            sledeci_btn.Enabled = true;
               

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                textBox1.Text = lista[0].ID.ToString();
                textBox2.Text = lista[0].Grad_ime;
                textBox3.Text = lista[0].Poz;
                textBox4.Text = lista[0].Postanski.ToString();
                textBox5.Text = lista[0].Br.ToString();
                brojac = 0;
                prethodni_btn.Enabled = false;
            }
            else
            {
                textBox1.Text = lista[brojac].ID.ToString();
                textBox2.Text = lista[brojac].Grad_ime;
                textBox3.Text = lista[brojac].Poz;
                textBox4.Text = lista[brojac].Postanski.ToString();
                textBox5.Text = lista[brojac].Br.ToString();
                   
            }
        }

        private void Novi_btn_Click(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            Upisi_btn.Enabled = true;
            prethodni_btn.Enabled = true;
            sledeci_btn.Enabled = true;

            textBox1.Text = null;
            textBox2.Text = null;
            textBox3.Text = null;
            textBox4.Text = null;
            textBox5.Text = null;
            textBox1.Select();
        }

        private void Upisi_btn_Click(object sender, EventArgs e)
        {
            SqlCommand provera = new SqlCommand("select GradID from Grad",conn);
            SqlCommand Upis = new SqlCommand("insert into Grad values(@p1,@p2,@p3,@p4,@p5)",conn);
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text) || String.IsNullOrEmpty(textBox2.Text) || String.IsNullOrEmpty(textBox3.Text) || String.IsNullOrEmpty(textBox4.Text) || String.IsNullOrEmpty(textBox5.Text))
                throw new Exception("Morate popuniti sve unose");

                if (textBox3.Text.Length > 4)
                    throw new Exception("Mozete uneti najvise 4 cifre kod pozivnog broja");

                for (int i = 0; i < textBox1.Text.Length; i++)
                {
                    if (!Char.IsDigit(textBox1.Text[i]))
                        throw new Exception("Moraju biti brojevi");
                }
                for (int i = 0; i < textBox4.Text.Length; i++)
                {
                    if (!Char.IsDigit(textBox4.Text[i]))
                        throw new Exception("Moraju biti brojevi");
                }
                for (int i = 0; i < textBox5.Text.Length; i++)
                {
                    if (!Char.IsDigit(textBox5.Text[i]))
                        throw new Exception("Moraju biti brojevi");
                }
                for (int i = 0; i < textBox2.Text.Length; i++)
                {
                    if (!Char.IsLetter(textBox2.Text[i]))
                        throw new Exception("Moraju biti brojevi");
                }
                for (int i = 0; i < textBox3.Text.Length; i++)
                {
                    if (Char.IsDigit(textBox3.Text[i]) || textBox3.Text[i] == '+')
                    { }
                    else
                    {
                        throw new Exception("Moraju biti brojevi ili +");
                    }
                }

                conn.Open();
                SqlDataReader rd = provera.ExecuteReader();
                while (rd.Read())
                {
                    if(Convert.ToInt32(textBox1.Text) == rd.GetInt32(0))
                        throw new Exception("Vec postoji ID");
                }
                conn.Close();

                conn.Open();
                Upis.Parameters.AddWithValue("@p1",Convert.ToInt32(textBox1.Text));
                Upis.Parameters.AddWithValue("@p2",textBox2.Text);
                Upis.Parameters.AddWithValue("@p3",textBox3.Text);
                Upis.Parameters.AddWithValue("@p4", Convert.ToInt32(textBox4.Text));
                Upis.Parameters.AddWithValue("@p5", Convert.ToInt32(textBox5.Text));

                Upis.ExecuteNonQuery();
                MessageBox.Show("Uspesno ste upisali");
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            finally { conn.Close(); }
        }
    }
}
