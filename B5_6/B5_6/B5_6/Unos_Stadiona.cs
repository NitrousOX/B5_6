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
    public partial class Unos_Stadiona : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-5V1MH83\DUGINSIGHT;Initial Catalog=B5_6;Integrated Security=True");
        List<Stadion> lista = new List<Stadion>();
        int brojac = 0;
        public Unos_Stadiona()
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
            for(int i=0;i<lista.Count;i++)
            { comboBox1.Items.Add(lista[i].Grad); }

            textBox1.Text = lista[0].ID.ToString();
            textBox2.Text = lista[0].Naziv;
            textBox3.Text = lista[0].Adresa;
            textBox4.Text = lista[0].Kapacitet.ToString();
            textBox5.Text = lista[0].BrUlaza.ToString();
            comboBox1.SelectedIndex = 0;
        }
        public void Ucitavanje_uListu()
        {
            lista.Clear();
            SqlCommand ucitavanje = new SqlCommand("select Stadion.StadionID ,Stadion.Naziv ,Stadion.Adresa ,Stadion.Kapacitet ,Stadion.BrojUlaza, Grad.Grad from Stadion join Grad on Grad.GradID = Stadion.GradID", conn);
            conn.Open();
            SqlDataReader rd = ucitavanje.ExecuteReader();
            while (rd.Read())
            {
                lista.Add(new Stadion(rd.GetInt32(0), rd.GetString(1), rd.GetString(2), rd.GetInt32(3), rd.GetInt32(4),rd.GetString(5)));
            }
            conn.Close();
        }
        public class Stadion
        {
            private int id;
            private string naziv;
            private string adresa;
            private int kapacitet;
            private int brulaza;
            private string grad;

            public Stadion(int id,string naziv,string adresa, int kapacitet, int brulaza, string grad)
            {
                this.id = id;
                this.grad = grad;
                this.naziv = naziv;
                this.adresa = adresa;
                this.brulaza = brulaza;
                this.kapacitet = kapacitet;
            }
            public int ID { get { return id; } }
            public string Grad { get { return grad; } }
            public string Naziv { get { return naziv; } }
            public string Adresa { get { return adresa; } }
            public int Kapacitet { get { return kapacitet; } }
            public int BrUlaza { get { return brulaza; } }


        }



        private void Izadji_btn_Click(object sender, EventArgs e)
        {
            this.Close();
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
                textBox2.Text = lista[lista.Count - 1].Naziv;
                textBox3.Text = lista[lista.Count - 1].Adresa;
                textBox4.Text = lista[lista.Count - 1].Kapacitet.ToString();
                textBox5.Text = lista[lista.Count - 1].BrUlaza.ToString();
                comboBox1.SelectedIndex = lista.Count - 1;
                sledeci_btn.Enabled = false;
            }
            else
            {
                textBox1.Text = lista[brojac].ID.ToString();
                textBox2.Text = lista[brojac].Naziv;
                textBox3.Text = lista[brojac].Adresa;
                textBox4.Text = lista[brojac].Kapacitet.ToString();
                textBox5.Text = lista[brojac].BrUlaza.ToString();

                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == lista[brojac].Grad)
                    {
                        comboBox1.SelectedIndex = i;
                    }

                }
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
                textBox2.Text = lista[0].Naziv;
                textBox3.Text = lista[0].Adresa;
                textBox4.Text = lista[0].Kapacitet.ToString();
                textBox5.Text = lista[0].BrUlaza.ToString();
                comboBox1.SelectedIndex = 0;
                brojac = 0;
                prethodni_btn.Enabled = false;
            }
            else
            {
                textBox1.Text = lista[brojac].ID.ToString();
                textBox2.Text = lista[brojac].Naziv;
                textBox3.Text = lista[brojac].Adresa;
                textBox4.Text = lista[brojac].Kapacitet.ToString();
                textBox5.Text = lista[brojac].BrUlaza.ToString();

                for (int i = 0; i < comboBox1.Items.Count; i++)
                {
                    if (comboBox1.Items[i].ToString() == lista[brojac].Grad)
                    {
                        comboBox1.SelectedIndex = i;
                    }

                }
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
            comboBox1.SelectedItem = null;
            textBox1.Select();
        }

        private void Upisi_btn_Click(object sender, EventArgs e)
        {
            //trebalo je odvojeno upisati sve gradove sa novom naredbom bez joina i sortirati, takodje sa novom listom gde imamo i GradID i Naziv pa kod upisivanja mozemo uzeti GradID koji nam treba;
        }
    }
}
