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
            this.SuspendLayout();
            // 
            // txt_desc_destino_final
            // 
            this.txt_desc_destino_final.Location = new System.Drawing.Point(285, 328);
            this.txt_desc_destino_final.Name = "txt_desc_destino_final";
            this.txt_desc_destino_final.Size = new System.Drawing.Size(205, 20);
            this.txt_desc_destino_final.TabIndex = 1;
            // 
            // txt_recolhimento
            // 
            this.txt_recolhimento.Location = new System.Drawing.Point(285, 442);
            this.txt_recolhimento.Name = "txt_recolhimento";
            this.txt_recolhimento.Size = new System.Drawing.Size(162, 20);
            this.txt_recolhimento.TabIndex = 2;
            // 
            // txt_reponsavel
            // 
            this.txt_reponsavel.Location = new System.Drawing.Point(498, 442);
            this.txt_reponsavel.Name = "txt_reponsavel";
            this.txt_reponsavel.Size = new System.Drawing.Size(100, 20);
            this.txt_reponsavel.TabIndex = 3;
            // 
            // txt_dados_responsavel
            // 
            this.txt_dados_responsavel.Location = new System.Drawing.Point(638, 442);
            this.txt_dados_responsavel.Name = "txt_dados_responsavel";
            this.txt_dados_responsavel.Size = new System.Drawing.Size(164, 20);
            this.txt_dados_responsavel.TabIndex = 4;
            // 
            // txt_destino_final
            // 
            this.txt_destino_final.Location = new System.Drawing.Point(858, 442);
            this.txt_destino_final.Name = "txt_destino_final";
            this.txt_destino_final.Size = new System.Drawing.Size(127, 20);
            this.txt_destino_final.TabIndex = 5;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(708, 79);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 6;
            this.btn_home.Text = "btn_home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.Location = new System.Drawing.Point(869, 79);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(75, 23);
            this.btn_calculadora.TabIndex = 7;
            this.btn_calculadora.Text = "btn_calculadora";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_volta
            // 
            this.btn_volta.Location = new System.Drawing.Point(166, 516);
            this.btn_volta.Name = "btn_volta";
            this.btn_volta.Size = new System.Drawing.Size(75, 23);
            this.btn_volta.TabIndex = 8;
            this.btn_volta.Text = "btn_volta";
            this.btn_volta.UseVisualStyleBackColor = true;
            this.btn_volta.Click += new System.EventHandler(this.btn_volta_Click);
            // 
            // btn_registrar
            // 
            this.btn_registrar.Location = new System.Drawing.Point(1036, 473);
            this.btn_registrar.Name = "btn_registrar";
            this.btn_registrar.Size = new System.Drawing.Size(75, 23);
            this.btn_registrar.TabIndex = 9;
            this.btn_registrar.Text = "btn_registrar";
            this.btn_registrar.UseVisualStyleBackColor = true;
            this.btn_registrar.Click += new System.EventHandler(this.btn_registrar_Click);
            // 
            // btn_pdf
            // 
            this.btn_pdf.Location = new System.Drawing.Point(1036, 525);
            this.btn_pdf.Name = "btn_pdf";
            this.btn_pdf.Size = new System.Drawing.Size(75, 23);
            this.btn_pdf.TabIndex = 10;
            this.btn_pdf.Text = "btn_pdf";
            this.btn_pdf.UseVisualStyleBackColor = true;
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
            // Plano4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.I;
            this.ClientSize = new System.Drawing.Size(1195, 669);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Plano4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano5";
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
    }
}