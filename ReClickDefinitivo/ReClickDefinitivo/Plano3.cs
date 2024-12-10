using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReClickDefinitivo
{
    public partial class Plano3 : Form
    {
        public Plano3()
        {
            InitializeComponent();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passando valores dos inputs para classe
            Plano pgrs = new Plano();
            pgrs.Coleta_reciclaveis = txt_reciclaveis.Text;
            pgrs.Coleta_rejeitos = txt_rejeitos.Text;
            pgrs.Coleta_perigosos = txt_perigosos.Text;
            pgrs.Coleta_organicos = txt_organicos.Text;

            Plano4 pla4 = new Plano4();
            pla4.Show();
            this.Hide();
        }

        private void btn_volta_Click(object sender, EventArgs e)
        {
            Plano2 pla2 = new Plano2();
            pla2.Show();
            this.Hide();
        }
    }
}
