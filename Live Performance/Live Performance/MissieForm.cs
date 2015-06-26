using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Live_Performance.Classes;
namespace Live_Performance
{
    using System.Diagnostics;

    public partial class MissieForm : Form
    {
        Administrator administrator = new Administrator();
        public MissieForm()
        {

            InitializeComponent();
        }

        private void cb_typemissie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_typemissie.SelectedText == "SIN")
            {
                btn_searchClosestBoot.Enabled = true;
            }
            else if (cb_typemissie.SelectedText == "HOPE")
            {
                btn_searchClosestBoot.Enabled = false;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_searchClosestBoot_Click(object sender, EventArgs e)
        {
            Boot closestBoot = this.administrator.Findclosestship(Convert.ToInt32(this.nud_X.Value), Convert.ToInt32(this.nud_Y.Value));
            lbl_closestboot.Text = closestBoot.Naam;
        }

        private void cb_profile_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_Profiel.Text = cb_profile.SelectedText;
        }

        private void btn_aanmaken_Click(object sender, EventArgs e)
        {
            bool actief = false;
            bool goedgekeurd = false;
            Location location = new Location(Convert.ToInt32(nud_X.Value), Convert.ToInt32(nud_Y.Value));
            if (cb_typemissie.SelectedText == "SIN")
            {
                goedgekeurd = true;
                actief = true;
            }
            Missie newMissie = new Missie(tb_MissieNaam.Text, actief, tb_datumvertrek.Text, tb_datumvertrek.Text, goedgekeurd, location, cb_typemissie.SelectedText);

            if (administrator.AddMissie(newMissie))
            {
                MessageBox.Show("Missie aangemaakt");
            }
            else
            {
                MessageBox.Show("Er is iets Misgegaan");
            }

        }
    }
}
