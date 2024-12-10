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
    public partial class Plano4 : Form
    {
        public Plano4()
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

        private void btn_volta_Click(object sender, EventArgs e)
        {
            Plano3 pla3 = new Plano3();
            pla3.Show();
            this.Hide();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            //passando valores dos inputs para classes
            Plano pgrs = new Plano();
            pgrs.Descricao_destino_final = txt_desc_destino_final.Text;
            pgrs.Recolhimento = txt_recolhimento.Text;
            pgrs.Responsavel = txt_reponsavel.Text;
            pgrs.Dados_responsavel = txt_dados_responsavel.Text;
            pgrs.Destino_final = txt_destino_final.Text;

            MessageBox.Show("Documento registrado por completo. Pronto para formatação em PDF");

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Plano pgrs = new Plano();
            //Gerar o relatorio
            string dados;
            dados = pgrs.Registrar_Plano();

            Font fonte25 = new Font("Georgia", 25);
            SolidBrush corfonteTitulo = new SolidBrush(Color.Black);

            Font fonte18 = new Font("Georgia", 18, FontStyle.Bold);
            Font fonte16 = new Font("Georgia", 16);
            SolidBrush corfonteTexto = new SolidBrush(Color.Black);

            e.Graphics.DrawString("Plano de Gerenciamento de Resíduos", fonte25, corfonteTitulo, new Point(60, 100));
            //e.Graphics.DrawString(dados, fonte16, corfonteTexto, new Point(60, 450));

            e.Graphics.DrawString("Nome", fonte18, corfonteTitulo, new Point(60, 250));
            e.Graphics.DrawString(pgrs.Nome, fonte16, corfonteTexto, new Point(60, 275));

            e.Graphics.DrawString("Email", fonte18, corfonteTitulo, new Point(60, 325));
            e.Graphics.DrawString(pgrs.Email, fonte16, corfonteTexto, new Point(60, 350));

            e.Graphics.DrawString("Telefone", fonte18, corfonteTitulo, new Point(60, 400));
            e.Graphics.DrawString(pgrs.Telefone, fonte16, corfonteTexto, new Point(60, 425));

            e.Graphics.DrawString("CNPJ", fonte18, corfonteTitulo, new Point(60, 475));
            e.Graphics.DrawString(pgrs.Cnpj, fonte16, corfonteTexto, new Point(60, 500));

            e.Graphics.DrawString("CEP", fonte18, corfonteTitulo, new Point(60, 550));
            e.Graphics.DrawString(pgrs.Cep, fonte16, corfonteTexto, new Point(60, 575));

            e.Graphics.DrawString("Município", fonte18, corfonteTitulo, new Point(60, 625));
            e.Graphics.DrawString(pgrs.Municipio, fonte16, corfonteTexto, new Point(60, 650));

            e.Graphics.DrawString("Unidade Federativa", fonte18, corfonteTitulo, new Point(60, 700));
            e.Graphics.DrawString(pgrs.Uf, fonte16, corfonteTexto, new Point(60, 725));

            e.Graphics.DrawString("Razão Social", fonte18, corfonteTitulo, new Point(60, 775));
            e.Graphics.DrawString(pgrs.Razao_social, fonte16, corfonteTexto, new Point(60, 800));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
    }
}
