using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B5_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void UnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Unos_Grada form = new Unos_Grada();
            form.Show();
        }

        private void KrajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SpisakIgracaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Spisakigraca form = new Spisakigraca();
            form.Show();
        }

        private void UnosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            Unos_Stadiona form = new Unos_Stadiona();
            form.Show();
        }

        private void KapacitetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kapacitet form = new kapacitet();
            form.Show();
        }
    }
}
