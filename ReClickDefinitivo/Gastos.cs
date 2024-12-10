using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ReClickDefinitivo
{
    class Gastos : Conexao
    {
        private int rejeitos, rejeitos_organicos, rejeitos_reciclaveis, rejeitos_perigosos, agua, energia;

        public int Agua
        {
            get
            {
                return agua;
            }

            set
            {
                agua = value;
            }
        }

        public int Energia
        {
            get
            {
                return energia;
            }

            set
            {
                energia = value;
            }
        }

        public int Rejeitos
        {
            get
            {
                return rejeitos;
            }

            set
            {
                rejeitos = value;
            }
        }

        public int Rejeitos_organicos
        {
            get
            {
                return rejeitos_organicos;
            }

            set
            {
                rejeitos_organicos = value;
            }
        }

        public int Rejeitos_perigosos
        {
            get
            {
                return rejeitos_perigosos;
            }

            set
            {
                rejeitos_perigosos = value;
            }
        }

        public int Rejeitos_reciclaveis
        {
            get
            {
                return rejeitos_reciclaveis;
            }

            set
            {
                rejeitos_reciclaveis = value;
            }
        }
        //método que insere novo registro no banco de dados
        public void Registrar_Gastos()
        {
            DateTime agora = DateTime.Now;
            Empresa emp = new Empresa();

            string query = "INSERT INTO gastos(id_usuario_empresa, data_hora, litros_agua, kwh_energia, kg_organicos, kg_rejeitos, kg_rejeitos_perigosos, kg_reciclaveis) " +
                   "VALUES (@IdEmpresa, @DateTime, @LitrosAgua, @KwhEnergia, @KgOrganicos, @KgRejeitos, @KgRejeitosPerigosos, @KgReciclaveis)";

            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.Parameters.Add("@IdEmpresa", MySqlDbType.Int32).Value = emp.Id;
                cmd.Parameters.Add("@DateTime", MySqlDbType.DateTime).Value = agora;
                cmd.Parameters.Add("@LitrosAgua", MySqlDbType.Int32).Value = this.agua;
                cmd.Parameters.Add("@KwhEnergia", MySqlDbType.Int32).Value = this.energia;
                cmd.Parameters.Add("@KgOrganicos", MySqlDbType.Int32).Value = this.rejeitos_organicos;
                cmd.Parameters.Add("@KgRejeitos", MySqlDbType.Int32).Value = this.rejeitos;
                cmd.Parameters.Add("@KgRejeitosPerigosos", MySqlDbType.Int32).Value = this.rejeitos_perigosos;
                cmd.Parameters.Add("@KgReciclaveis", MySqlDbType.Int32).Value = this.rejeitos_reciclaveis;

                cmd.ExecuteNonQuery();
                this.fecharConexao();
            }

            /*
            string query = "INSERT INTO gastos(id_usuario_empresa, data_hora, litros_agua,kwh_energia,kg_organicos,kg_rejeitos,kg_rejeitos_perigosos,kg_reciclaveis) VALUES ('" +
               emp.Id + "',' @DateTime ' , '" + this.agua + "' , '" + this.energia + "' , '" + this.rejeitos_organicos + "', '" + this.rejeitos + "', '" + this.rejeitos_perigosos + "', '" + this.rejeitos_reciclaveis + "')";
            if (this.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conectar);
                cmd.Parameters.Add("@DateTime", MySqlDbType.DateTime).Value = agora;
                cmd.ExecuteNonQuery();
                this.fecharConexao();

            }
            */
        }
        //método que procura registro do combobox no banco de dados
        public DataTable Consultar_Gastos(int id_registro)
        {
            this.abrirConexao();
            string query = "SELECT litros_agua, kwh_energia, kg_organicos, kg_rejeitos, kg_rejeitos_perigosos, kg_reciclaveis FROM gastos WHERE id = '"+ id_registro +"'; ";
            MySqlCommand cmd = new MySqlCommand(query, conectar);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            this.fecharConexao();
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        
        //
        }
    }


