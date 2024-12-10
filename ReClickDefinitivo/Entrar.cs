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
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro();
            cad.Show();
            this.Hide();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            //instanciando classe usuário-empresa
            Empresa emp = new Empresa();

            if (string.IsNullOrWhiteSpace(txt_email.Text)|| string.IsNullOrWhiteSpace(msk_cnpj.Text)) {
                MessageBox.Show("Preencha todos os campos do formulário de login");
            }
            else
            {
                //passando os dados de login para variáveis
                string email = txt_email.Text;
                string cnpj = msk_cnpj.Text;

                try
                {
                    //passando dados de login para classe
                    emp.Email = email;
                    emp.Cnpj = cnpj;

                    //executando método de login
                    bool sucesso_login = emp.Logar();

                    if (sucesso_login == true)
                    {
                        MessageBox.Show("Logado com sucesso!");
                        Home hm = new Home();
                        hm.Show();
                        this.Hide();
                    }
                    else if (sucesso_login == false) {
                        MessageBox.Show("Empresa não encontrada. Verifique suas credenciais.");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao tentar logar");
                }
            }
            
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

        private void Entrar_Load(object sender, EventArgs e)
        {

        }
    }
}
