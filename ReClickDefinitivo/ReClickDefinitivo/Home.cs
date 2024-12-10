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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            Entrar ent = new Entrar();
            ent.Show();
            this.Hide();
            
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
            this.Hide();
        }

        private void btn_lixeira_Click(object sender, EventArgs e)
        {

        }
    }
}
