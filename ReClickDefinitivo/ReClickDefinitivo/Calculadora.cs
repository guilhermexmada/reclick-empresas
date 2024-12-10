using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;



namespace ReClickDefinitivo
{
    public partial class Calculadora : Form
    {

        private DataTable ds = new DataTable();
        private Gastos gas = new Gastos();

        private List<string> rejeitos = new List<string>();
        private List<string> organicos = new List<string>();
        private List<string> reciclaveis = new List<string>();
        private List<string> perigosos = new List<string>();
        private List<string> agua = new List<string>();
        private List<string> energia = new List<string>();
        private List<string> id = new List<string>();


        public Calculadora()
        {
            InitializeComponent();
            Historico_Gastos();
        }
        private void MontaGrafico()
        {
            if(cmb_registros.SelectedItem == null) {
                MessageBox.Show("Selecione o registro");
                return;
            }
            //limpando dados do gráfico
            cht_Gastos.Series[0].Points.Clear();
            //passando consulta para datatable
            ds = gas.Consultar_Gastos(int.Parse(cmb_registros.SelectedItem.ToString()));

            if (ds.Rows.Count > 0)
            {
                // Acesso aos dados retornados
                string litros_agua = ds.Rows[0]["litros_agua"].ToString();
                string kwh_energia = ds.Rows[0]["kwh_energia"].ToString();
                string kg_organicos = ds.Rows[0]["kg_organicos"].ToString();
                string kg_rejeitos = ds.Rows[0]["kg_rejeitos"].ToString();
                string kg_rejeitos_perigosos = ds.Rows[0]["kg_rejeitos_perigosos"].ToString();
                string kg_reciclaveis = ds.Rows[0]["kg_reciclaveis"].ToString();
                //criando barra para cada dado
                cht_Gastos.Series[0].ChartType = SeriesChartType.Pie;
                cht_Gastos.Series[0].Points.AddXY("Água", litros_agua);
                cht_Gastos.Series[0].Points.AddXY("Energia", kwh_energia);
                cht_Gastos.Series[0].Points.AddXY("Orgânicos", kg_organicos);
                cht_Gastos.Series[0].Points.AddXY("Rejeitos", kg_rejeitos);
                cht_Gastos.Series[0].Points.AddXY("Perigosos", kg_rejeitos_perigosos);
                cht_Gastos.Series[0].Points.AddXY("Recicláveis", kg_reciclaveis);
                // Define o título do gráfico
                cht_Gastos.Titles.Clear();
                cht_Gastos.Titles.Add("Gastos");
                // Define os títulos dos eixos X e Y
                cht_Gastos.ChartAreas[0].AxisX.Title = "Colunas";
                cht_Gastos.ChartAreas[0].AxisY.Title = "Valores";
                cht_Gastos.Palette = ChartColorPalette.Excel;
                cht_Gastos.Series[0].IsValueShownAsLabel = true;
            }
            else
            {
                MessageBox.Show("Erro! Nenhum valor encontrado no registro que você escolheu");
                return;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Home hm = new Home();
            hm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculadora calc = new Calculadora();
            calc.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Plano1 pla1 = new Plano1();
            pla1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Gerar_Click(object sender, EventArgs e)
        {
            MontaGrafico();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Empresa emp = new Empresa();
            MessageBox.Show("Seu id: " + emp.Id);
        }

        //recupera os registros dos gastos para selecionar e exibir no combobox
        public void Historico_Gastos()
        {
            Conexao conn = new Conexao();
            Empresa emp = new Empresa();

            string query = "SELECT id FROM gastos WHERE id_usuario_empresa = '"+ emp.Id + "'; ";
            if (conn.abrirConexao() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, conn.conectar);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cmb_registros.Items.Add(reader["id"].ToString());
                }

                reader.Close();
                conn.fecharConexao();

            }
        }

        private void cmb_registros_SelectedIndexChanged(object sender, EventArgs e)
        {
            //configurando gráfico a partir do registro no combobox
            if (cmb_registros.SelectedItem != null)
            {
                string itemSelecionado = cmb_registros.SelectedItem.ToString();
                //MessageBox.Show(itemSelecionado);
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //inserindo gastos no banco de dados
            if (string.IsNullOrWhiteSpace(txt_agua.Text) || string.IsNullOrWhiteSpace(txt_energia.Text) || string.IsNullOrWhiteSpace(txt_rejeitos.Text) || string.IsNullOrWhiteSpace(txt_rejeitos_organicos.Text) || string.IsNullOrWhiteSpace(txt_rejeitos_perigosos.Text) || string.IsNullOrWhiteSpace(txt_rejeitos_reciclaveis.Text))
            {
                MessageBox.Show("Preencha todos os campos");
            }
            else
            {
                Gastos gas = new Gastos();
                gas.Agua = int.Parse(txt_agua.Text);
                gas.Energia = int.Parse(txt_energia.Text);
                gas.Rejeitos_reciclaveis = int.Parse(txt_rejeitos_reciclaveis.Text);
                gas.Rejeitos = int.Parse(txt_rejeitos.Text);
                gas.Rejeitos_perigosos = int.Parse(txt_rejeitos_perigosos.Text);
                gas.Rejeitos_organicos = int.Parse(txt_rejeitos_organicos.Text);
                gas.Registrar_Gastos();

                MessageBox.Show("Os seus gastos foram salvos!");
                Historico_Gastos();
                //
            }
            
        }
    }
}
