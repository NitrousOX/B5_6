using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5B6_Fudbalski_klub_i_utakmice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void krajRadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void unosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void kapacitetStadionaToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void spisakIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisak sp = new Spisak();
            sp.ShowDialog();
        }

        private void unosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Gradovi gr = new Gradovi();
            gr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
