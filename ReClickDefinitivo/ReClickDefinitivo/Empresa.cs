using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReClickDefinitivo
{
    class Empresa : Conexao
    {
        private string nome;
        private string email;
        private string telefone;
        private string cnpj;
        private string municipio;
        private string cep;
        private string uf;
        private string razao_social;
        private static int id;

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Cnpj
        {
            get
            {
                return cnpj;
            }

            set
            {
                cnpj = value;
            }
        }

        public string Municipio
        {
            get
            {
                return municipio;
            }

            set
            {
                municipio = value;
            }
        }

        public string Cep
        {
            get
            {
                return cep;
            }

            set
            {
                cep = value;
            }
        }

        public string Uf
        {
            get
            {
                return uf;
            }

            set
            {
                uf = value;
            }
        }

        public string Razao_social
        {
            get
            {
                return razao_social;
            }

            set
            {
                razao_social = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        //método que insere novo registro no banco de dados
        public void Inserir()
        {
            string query = "INSERT INTO usuario_empresa(nome,email,telefone,cnpj,municipio,cep,uf,razao_social) VALUES ('" +
               this.nome + "' , '" + this.email + "' , '" + this.telefone + "', '" + this.cnpj + "', '" + this.municipio + "', '" + this.cep + "', '" + this.uf + "', '" + this.razao_social + "')";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.ExecuteNonQuery();
                this.fecharConexao();

            }
        }

        //método que verifica existência de registro para logar
        //loga guardando cnpj no atributo cnpj_login
        public bool Logar()
        {

            //escrevendo consulta 
            string query = "SELECT id FROM usuario_empresa WHERE email =  '" + this.email + "' and cnpj = '" + this.cnpj + "' ";
            MySqlCommand cmd = new MySqlCommand(query, conectar);

            //executando SELECT e lendo
            abrirConexao();
            var result = cmd.ExecuteReader();

            //guardando id da empresa encontrada
            if (result.Read())
            {
                Empresa.id = Convert.ToInt32(result["id"]);
                return true;
            }
            else {
                Console.WriteLine("Não existe registro no banco");
                fecharConexao();
                return false;
            }

        }
    }
}