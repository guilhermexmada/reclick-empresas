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
      //  private PrintDialog printDocument = new PrintDialog();
     //   private Image imageToPrint;
        public Plano4()
        {
            InitializeComponent();

          //  imageToPrint = Image.FromFile("link da foto");

            //// Associar o evento PrintPage ao PrintDocument
          //  printDocument1.PrintPage += (sender, e) =>
          //  {
               // // Desenha a imagem diretamente, sem redimensionar ou ajustar
               // //  e.Graphics.DrawImage(imageToPrint, e.MarginBounds.Left, e.MarginBounds.Top);
              //  e.Graphics.DrawImage(imageToPrint, 55, 50);
          //  };
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

        private int pagina = 1;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //e.HasMorePages = false;

            //e.Graphics.DrawString("Descrição destino final", fonte18, corfonteTitulo, new Point(60, 725));
            //e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 750));

            //e.Graphics.DrawString("Recolhimento", fonte18, corfonteTitulo, new Point(60, 725));
            //e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 750));

            //e.Graphics.DrawString("Responsável", fonte18, corfonteTitulo, new Point(60, 725));
            //e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 750));

            //e.Graphics.DrawString("Dados responsável", fonte18, corfonteTitulo, new Point(60, 725));
            //e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 750));

            //e.Graphics.DrawString("Descrição do cálculo", fonte18, corfonteTitulo, new Point(60, 725));
            //e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 750));

                 

            //RectangleF areaTexto2 = new RectangleF(180, 340, 400, 590);
            //e.Graphics.DrawString(pgrs.Descricao_projetos, fonte16, corfonteTexto, areaTexto2);

            //RectangleF areaTexto3 = new RectangleF(180, 340, 400, 590);
            //e.Graphics.DrawString(pgrs.Coleta_reciclaveis, fonte16, corfonteTexto, areaTexto3);

            //RectangleF areaTexto4 = new RectangleF(180, 340, 400, 590);
            //e.Graphics.DrawString(pgrs.Coleta_perigosos, fonte16, corfonteTexto, areaTexto4);

            //RectangleF areaTexto5 = new RectangleF(180, 340, 400, 590);
            //e.Graphics.DrawString(pgrs.Coleta_rejeitos, fonte16, corfonteTexto, areaTexto5);

            //RectangleF areaTexto6 = new RectangleF(180, 340, 400, 590);
            //e.Graphics.DrawString(pgrs.Coleta_organicos, fonte16, corfonteTexto, areaTexto6);

            //RectangleF areaTexto7 = new RectangleF(180, 340, 400, 590);
            //e.Graphics.DrawString(pgrs.Descricao_destino_final, fonte16, corfonteTexto, areaTexto7);

            Plano pgrs = new Plano();
            //Gerar o relatorio
            string dados;
            dados = pgrs.Registrar_Plano();

            //configurando fontes
            Font fonte25 = new Font("Arial", 25);
            SolidBrush corfonteTitulo = new SolidBrush(Color.Black);
            Font fonte18 = new Font("Arial", 17, FontStyle.Bold);
            Font fonte16 = new Font("Arial", 14);
            SolidBrush corfonteTexto = new SolidBrush(Color.Black);
            Pen pen = new Pen(Color.Black, 2);

            if(pagina == 1)
            {
                //primeira página
                e.Graphics.DrawString("Plano de Gerenciamento de Resíduos Sólidos", fonte25, corfonteTitulo, new Point(60, 125));
                e.Graphics.DrawString("Este documento pretende fornecer as especificações dos processos de geração\n" +
                     "e destinação de resíduos sólidos da instituição referente. Seu desenvolvimento\n" +
                     "foi pautado de acordo com as diretrizes da Lei Federal n° 12.305, do dia 02 de\n" +
                     "agosto de 2010, que instituiu a Política Nacional de Resíduos Sólidos.\n", fonte16, corfonteTexto, new Point(60, 175));

                e.Graphics.DrawString("Identificação da Instituição", fonte25, corfonteTitulo, new Point(60, 300));

                e.Graphics.DrawString("Nome", fonte18, corfonteTitulo, new Point(60, 350));
                e.Graphics.DrawString(pgrs.Nome, fonte16, corfonteTexto, new Point(60, 375));

                e.Graphics.DrawString("Email", fonte18, corfonteTitulo, new Point(310, 350));
                e.Graphics.DrawString(pgrs.Email, fonte16, corfonteTexto, new Point(310, 375));

                e.Graphics.DrawString("Telefone", fonte18, corfonteTitulo, new Point(560, 350));
                e.Graphics.DrawString(pgrs.Telefone, fonte16, corfonteTexto, new Point(560, 375));

                e.Graphics.DrawString("CNPJ", fonte18, corfonteTitulo, new Point(60, 425));
                e.Graphics.DrawString(pgrs.Cnpj, fonte16, corfonteTexto, new Point(60, 450));

                e.Graphics.DrawString("CEP", fonte18, corfonteTitulo, new Point(310, 425));
                e.Graphics.DrawString(pgrs.Cep, fonte16, corfonteTexto, new Point(310, 450));

                e.Graphics.DrawString("Município", fonte18, corfonteTitulo, new Point(560, 425));
                e.Graphics.DrawString(pgrs.Municipio, fonte16, corfonteTexto, new Point(560, 450));

                e.Graphics.DrawString("UF", fonte18, corfonteTitulo, new Point(60, 500));
                e.Graphics.DrawString(pgrs.Uf, fonte16, corfonteTexto, new Point(60, 525));

                e.Graphics.DrawString("Razão Social", fonte18, corfonteTitulo, new Point(310, 500));
                e.Graphics.DrawString(pgrs.Razao_social, fonte16, corfonteTexto, new Point(310, 525));

                e.Graphics.DrawString("Número de usuários", fonte18, corfonteTitulo, new Point(560, 500));
                e.Graphics.DrawString(pgrs.Usuarios, fonte16, corfonteTexto, new Point(560, 525));

                e.Graphics.DrawString("Responsável Legal", fonte18, corfonteTitulo, new Point(60, 575));
                e.Graphics.DrawString(pgrs.Responsavel_legal, fonte16, corfonteTexto, new Point(60, 600));

                e.Graphics.DrawString("Responsável pelo PGRS", fonte18, corfonteTitulo, new Point(310, 575));
                e.Graphics.DrawString(pgrs.Responsavel_pgrs, fonte16, corfonteTexto, new Point(310, 600));

                e.Graphics.DrawString("Data", fonte18, corfonteTitulo, new Point(60, 650));
                e.Graphics.DrawString(pgrs.Data, fonte16, corfonteTexto, new Point(60, 675));

                e.Graphics.DrawString("Descrição geral", fonte18, corfonteTitulo, new Point(60, 725));
                e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 750));

                e.Graphics.DrawLine(pen, 10, 800, 810, 800);

                e.Graphics.DrawString("Apresentação e Objetivos", fonte25, corfonteTitulo, new Point(60, 850));
                e.Graphics.DrawString(
                           "O presente Plano de Gerenciamento de Resíduos Sólidos - PGRS, é baseado\n " +
                     "na Legislação vigente, que estabelece princípios básicos da minimização da\n" +
                     "geração de resíduos levando em consideração etapas como geração, segre-\n" +
                     "gação, acondicionamento, identificação, coleta, transporte e tratamento inter-\n" +
                     "nos, armazenamento temporário e coleta e transporte externos, além da dis-\n" +
                     "posição final devidamente licensiada pelo órgão ambiental competente.\n" , fonte16, corfonteTexto, new Point(60, 900));
                //fim da primeira página

                pagina++;
                e.HasMorePages = true;
            } else if(pagina == 2)
            {
                //segunda página
                e.Graphics.DrawString("1. Descrição cálculo de resíduos totais gerados", fonte18, corfonteTitulo, new Point(60, 150));
                e.Graphics.DrawString(pgrs.Descricao_calculo, fonte16, corfonteTexto, new Point(60, 175));

                e.Graphics.DrawString("2. Descrição dos projetos de educação ambiental", fonte18, corfonteTitulo, new Point(60, 275));
                e.Graphics.DrawString(pgrs.Descricao_projetos, fonte16, corfonteTexto, new Point(60, 300));

                e.Graphics.DrawString("Sobre coleta, transporte e acondicionamento", fonte25, corfonteTitulo, new Point(60, 450));
                e.Graphics.DrawString("Segue abaixo o detalhamento de cada etapa referida para cada tipo de resíduo \n" +
                    "gerado na empresa, segundo os parâmetros definidos na Legislação vigente \n" +
                    "e embasado na implementação de ferramentas e técnicas que otimizem \n" +
                    "todos os processos englobados no descarte destes materiais."
                    , fonte16, corfonteTexto, new Point(60, 500));

                e.Graphics.DrawString("3. Descrição da coleta dos recicláveis", fonte18, corfonteTitulo, new Point(60, 650));
                e.Graphics.DrawString(pgrs.Coleta_reciclaveis, fonte16, corfonteTexto, new Point(60, 675));

                e.Graphics.DrawString("4. Descrição da coleta dos rejeitos", fonte18, corfonteTitulo, new Point(60, 775));
                e.Graphics.DrawString(pgrs.Coleta_rejeitos, fonte16, corfonteTexto, new Point(60, 800));

                e.Graphics.DrawString("5. Descrição da coleta dos rejeitos perigosos", fonte18, corfonteTitulo, new Point(60, 900));
                e.Graphics.DrawString(pgrs.Coleta_perigosos, fonte16, corfonteTexto, new Point(60, 925));

                e.Graphics.DrawString("6. Descrição da coleta dos resíduos orgânicos", fonte18, corfonteTitulo, new Point(60, 1025));
                e.Graphics.DrawString(pgrs.Coleta_organicos, fonte16, corfonteTexto, new Point(60, 1050));

               // e.Graphics.DrawLine(pen, 10, 950, 810, 950);
                //fim da segunda página

                pagina++;
                e.HasMorePages = true;
            } else if(pagina == 3)
            {
                e.Graphics.DrawString("7. Descrição da destinação final", fonte18, corfonteTitulo, new Point(60, 150));
                e.Graphics.DrawString(pgrs.Descricao, fonte16, corfonteTexto, new Point(60, 175));

                e.Graphics.DrawString("8. Período de recolhimento", fonte18, corfonteTitulo, new Point(60, 275));
                e.Graphics.DrawString(pgrs.Recolhimento, fonte16, corfonteTexto, new Point(60, 300));

                e.Graphics.DrawString("9. Responsável pela destinação final", fonte18, corfonteTitulo, new Point(60, 400));
                e.Graphics.DrawString(pgrs.Dados_responsavel, fonte16, corfonteTexto, new Point(60, 425));

                e.Graphics.DrawString("10. Destino final", fonte18, corfonteTitulo, new Point(60, 525));
                e.Graphics.DrawString(pgrs.Destino_final, fonte16, corfonteTexto, new Point(60, 550));

                e.Graphics.DrawLine(pen, 450, 800, 750, 800);
                e.Graphics.DrawString("Local e data", fonte16, corfonteTexto, new Point(530, 810));

                e.Graphics.DrawLine(pen, 200, 950, 600, 950);
                e.Graphics.DrawString("Assinatura do responsável", fonte16, corfonteTexto, new Point(300, 960));

            }






        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btn_pdf_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void txt_desc_destino_final_TextChanged(object sender, EventArgs e)
        {

        }

        private void Plano4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrar ent = new Entrar();
            Empresa emp = new Empresa();
            emp.Id = 0;
            ent.Show();
            this.Hide();
        }
    }
}
