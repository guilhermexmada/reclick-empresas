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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {
            //instanciando classe do usuário-empresa
            Empresa emp = new Empresa();

            if (txt_email == null || txt_nome == null || txt_municipio == null || txt_telefone == null || txt_uf == null || txt_razao_social == null || msk_cep == null || msk_cnpj == null)
            {
                MessageBox.Show("Preencha todos os campos do formulário de cadastro!");
            }
            else {
                //passando todos os valores não nulos dos inputs para variáveis
                string nome = txt_nome.Text;
                string email = txt_email.Text;
                string tel = txt_telefone.Text;
                string cnpj = msk_cnpj.Text;
                string mun = txt_municipio.Text;
                string cep = msk_cep.Text;
                string uf = txt_uf.Text;
                string raz = txt_razao_social.Text;

                try
                {
                    //inserindo dados cadastrais na classe empresa
                    emp.Nome = nome;
                    emp.Email = email;
                    emp.Telefone = tel;
                    emp.Cnpj = cnpj;
                    emp.Municipio = mun;
                    emp.Cep = cep;
                    emp.Uf = uf;
                    emp.Razao_social = raz;

                    //executando método de inserção no banco de dados
                    emp.Inserir();

                    MessageBox.Show("Empresa cadastrada com sucesso");
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro ao cadastrar");
                }

                
            }

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

        private void btn_login_Click(object sender, EventArgs e)
        {
            Entrar ent = new Entrar();
            ent.Show();
            this.Hide();
        }
    }
}
