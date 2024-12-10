using MySql.Data.MySqlClient;
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
    public partial class Plano1 : Form
    {
        public Plano1()
        {
            InitializeComponent();
            Recuperar();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             
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

        private void Plano1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //passando valores dos inputs para classe
            Plano pgrs = new Plano();
            pgrs.Nome = txt_nome.Text;
            pgrs.Email = txt_email.Text;
            pgrs.Telefone = txt_telefone.Text;
            pgrs.Cnpj = txt_cnpj.Text;
            pgrs.Cep = txt_cep.Text;
            pgrs.Municipio = txt_municipio.Text;
            pgrs.Uf = txt_uf.Text;
            pgrs.Usuarios = txt_usuarios.Text;
            pgrs.Responsavel_legal = txt_responsavel_legal.Text;
            pgrs.Responsavel_pgrs = txt_responsavel_pgrs.Text;
            pgrs.Data = txt_data.Text;
            pgrs.Descricao = txt_descricao.Text;
            pgrs.Razao_social = txt_razao.Text;

            Plano2 pla2 = new Plano2();
            pla2.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        //recuperando dados da empresa e inicializando inputs cadastrais
        public void Recuperar()
        {
            Conexao conn = new Conexao();
            Empresa emp = new Empresa();

            string query = "SELECT nome,cnpj,email,razao_social,telefone,cep,uf,municipio FROM usuario_empresa WHERE id = '" + emp.Id + "'; ";
            if (conn.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn.conectar);
                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    txt_nome.Text = reader["nome"].ToString();
                    txt_cnpj.Text = reader["cnpj"].ToString();
                    txt_email.Text = reader["email"].ToString();
                    txt_razao.Text = reader["razao_social"].ToString();
                    txt_telefone.Text = reader["telefone"].ToString();
                    txt_cep.Text = reader["cep"].ToString();
                    txt_uf.Text = reader["uf"].ToString();
                    txt_municipio.Text = reader["municipio"].ToString();
                }

                


                reader.Close();
                conn.fecharConexao();
            }
            else
            {
                MessageBox.Show("Erro ao recuperar seus dados cadastrais");
            }
        }

        private void txt_responsavel_pgrs_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_descricao_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_municipio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Entrar ent = new Entrar();
            Empresa emp = new Empresa();
            emp.Id = 0;
            ent.Show();
            this.Hide();
        }

        private void txt_cnpj_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_cep_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
