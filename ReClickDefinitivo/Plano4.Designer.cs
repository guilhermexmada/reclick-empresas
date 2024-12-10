namespace ReClickDefinitivo
{
    partial class Plano4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plano4));
            this.txt_desc_destino_final = new System.Windows.Forms.TextBox();
            this.txt_recolhimento = new System.Windows.Forms.TextBox();
            this.txt_reponsavel = new System.Windows.Forms.TextBox();
            this.txt_dados_responsavel = new System.Windows.Forms.TextBox();
            this.txt_destino_final = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.btn_volta = new System.Windows.Forms.Button();
            this.btn_registrar = new System.Windows.Forms.Button();
            this.btn_pdf = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_desc_destino_final
            // 
            this.txt_desc_destino_final.Location = new System.Drawing.Point(329, 341);
            this.txt_desc_destino_final.Multiline = true;
            this.txt_desc_destino_final.Name = "txt_desc_destino_final";
            this.txt_desc_destino_final.Size = new System.Drawing.Size(711, 70);
            this.txt_desc_destino_final.TabIndex = 1;
            this.txt_desc_destino_final.TextChanged += new System.EventHandler(this.txt_desc_destino_final_TextChanged);
            // 
            // txt_recolhimento
            // 
            this.txt_recolhimento.Location = new System.Drawing.Point(329, 442);
            this.txt_recolhimento.Name = "txt_recolhimento";
            this.txt_recolhimento.Size = new System.Drawing.Size(162, 20);
            this.txt_recolhimento.TabIndex = 2;
            // 
            // txt_reponsavel
            // 
            this.txt_reponsavel.Location = new System.Drawing.Point(550, 442);
            this.txt_reponsavel.Name = "txt_reponsavel";
            this.txt_reponsavel.Size = new System.Drawing.Size(100, 20);
            this.txt_reponsavel.TabIndex = 3;
            // 
            // txt_dados_responsavel
            // 
            this.txt_dados_responsavel.Location = new System.Drawing.Point(688, 442);
            this.txt_dados_responsavel.Name = "txt_dados_responsavel";
            this.txt_dados_responsavel.Size = new System.Drawing.Size(164, 20);
            this.txt_dados_responsavel.TabIndex = 4;
            // 
            // txt_destino_final
            // 
            this.txt_destino_final.Location = new System.Drawing.Point(913, 442);
            this.txt_destino_final.Name = "txt_destino_final";
            this.txt_destino_final.Size = new System.Drawing.Size(127, 20);
            this.txt_destino_final.TabIndex = 5;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_home4;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.Transparent;
            this.btn_home.Location = new System.Drawing.Point(697, 75);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(115, 58);
            this.btn_home.TabIndex = 6;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculadora.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_lixeira5;
            this.btn_calculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculadora.ForeColor = System.Drawing.Color.Transparent;
            this.btn_calculadora.Location = new System.Drawing.Point(856, 75);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(113, 58);
            this.btn_calculadora.TabIndex = 7;
            this.btn_calculadora.UseVisualStyleBackColor = false;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_volta
            // 
            this.btn_volta.BackColor = System.Drawing.Color.Transparent;
            this.btn_volta.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_voltar3;
            this.btn_volta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volta.ForeColor = System.Drawing.Color.Transparent;
            this.btn_volta.Location = new System.Drawing.Point(335, 552);
            this.btn_volta.Name = "btn_volta";
            this.btn_volta.Size = new System.Drawing.Size(93, 28);
            this.btn_volta.TabIndex = 8;
            this.btn_volta.UseVisualStyleBackColor = false;
            this.btn_volta.Click += new System.EventHandler(this.btn_volta_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrar.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_registrar;
            this.btn_registrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_registrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registrar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_registrar.Location = new System.Drawing.Point(748, 552);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(91, 28);
            this.btn_registrar.TabIndex = 9;
            this.btn_registrar.UseVisualStyleBackColor = false;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.BackColor = System.Drawing.Color.Transparent;
            this.btn_pdf.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_gerar_pdf;
            this.btn_pdf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_pdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pdf.ForeColor = System.Drawing.Color.Transparent;
            this.btn_pdf.Location = new System.Drawing.Point(891, 552);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(86, 28);
            this.btn_pdf.TabIndex = 10;
            this.btn_pdf.UseVisualStyleBackColor = false;
            this.btn_pdf.Click += new System.EventHandler(this.btn_pdf_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            this.printPreviewDialog1.Load += new System.EventHandler(this.printPreviewDialog1_Load);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_sair5;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1015, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 58);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Plano4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.pag_plano4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_pdf);
            this.Controls.Add(this.btn_registrar);
            this.Controls.Add(this.btn_volta);
            this.Controls.Add(this.btn_calculadora);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_destino_final);
            this.Controls.Add(this.txt_dados_responsavel);
            this.Controls.Add(this.txt_reponsavel);
            this.Controls.Add(this.txt_recolhimento);
            this.Controls.Add(this.txt_desc_destino_final);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Plano4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano5";
            this.Load += new System.EventHandler(this.Plano4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_desc_destino_final;
        private System.Windows.Forms.TextBox txt_recolhimento;
        private System.Windows.Forms.TextBox txt_reponsavel;
        private System.Windows.Forms.TextBox txt_dados_responsavel;
        private System.Windows.Forms.TextBox txt_destino_final;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_calculadora;
        private System.Windows.Forms.Button btn_volta;
        private System.Windows.Forms.Button btn_registrar;
        private System.Windows.Forms.Button btn_pdf;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button1;
    }
}