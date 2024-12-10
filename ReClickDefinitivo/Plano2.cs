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
    public partial class Plano2 : Form
    {
        public Plano2()
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
            Lixeira lixo = new Lixeira();
            lixo.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passando valores dos inputs para classe
            Plano pgrs = new Plano();
            pgrs.Descricao_calculo = txt_calculo.Text;
            pgrs.Descricao_projetos = txt_projeto.Text;

            Plano3 pla3 = new Plano3();
            pla3.Show();
            this.Hide();
        }

        private void Plano2_Load(object sender, EventArgs e)
        {
            //Plano pgrs = new Plano();
            //MessageBox.Show(pgrs.Nome);
        }

        private void btn_volta_Click(object sender, EventArgs e)
        {
            Plano1 pla1 = new Plano1();
            pla1.Show();
            this.Hide();
        }

        private void txt_classificacao_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Entrar ent = new Entrar();
            Empresa emp = new Empresa();
            emp.Id = 0;
            ent.Show();
            this.Hide();
        }
    }
}
