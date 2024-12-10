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
    public partial class Lixeira : Form
    {
        public Lixeira()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Entrar ent = new Entrar();
            ent.Show();
            this.Hide();
        }
    }
}
