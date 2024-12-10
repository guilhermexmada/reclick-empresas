namespace ReClickDefinitivo
{
    partial class Plano3
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
            this.txt_reciclaveis = new System.Windows.Forms.TextBox();
            this.txt_perigosos = new System.Windows.Forms.TextBox();
            this.txt_rejeitos = new System.Windows.Forms.TextBox();
            this.txt_organicos = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.btn_para_4 = new System.Windows.Forms.Button();
            this.btn_volta = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_reciclaveis
            // 
            this.txt_reciclaveis.Location = new System.Drawing.Point(324, 340);
            this.txt_reciclaveis.Multiline = true;
            this.txt_reciclaveis.Name = "txt_reciclaveis";
            this.txt_reciclaveis.Size = new System.Drawing.Size(262, 60);
            this.txt_reciclaveis.TabIndex = 1;
            // 
            // txt_perigosos
            // 
            this.txt_perigosos.Location = new System.Drawing.Point(324, 443);
            this.txt_perigosos.Multiline = true;
            this.txt_perigosos.Name = "txt_perigosos";
            this.txt_perigosos.Size = new System.Drawing.Size(262, 59);
            this.txt_perigosos.TabIndex = 2;
            this.txt_perigosos.TextChanged += new System.EventHandler(this.txt_perigosos_TextChanged);
            // 
            // txt_rejeitos
            // 
            this.txt_rejeitos.Location = new System.Drawing.Point(661, 340);
            this.txt_rejeitos.Multiline = true;
            this.txt_rejeitos.Name = "txt_rejeitos";
            this.txt_rejeitos.Size = new System.Drawing.Size(262, 60);
            this.txt_rejeitos.TabIndex = 3;
            // 
            // txt_organicos
            // 
            this.txt_organicos.Location = new System.Drawing.Point(661, 443);
            this.txt_organicos.Multiline = true;
            this.txt_organicos.Name = "txt_organicos";
            this.txt_organicos.Size = new System.Drawing.Size(262, 59);
            this.txt_organicos.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.Transparent;
            this.btn_home.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_home3;
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.ForeColor = System.Drawing.Color.Transparent;
            this.btn_home.Location = new System.Drawing.Point(695, 78);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(117, 53);
            this.btn_home.TabIndex = 5;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculadora.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_lixeira4;
            this.btn_calculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculadora.ForeColor = System.Drawing.Color.Transparent;
            this.btn_calculadora.Location = new System.Drawing.Point(850, 78);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(118, 53);
            this.btn_calculadora.TabIndex = 6;
            this.btn_calculadora.UseVisualStyleBackColor = false;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_para_4
            // 
            this.btn_para_4.BackColor = System.Drawing.Color.Transparent;
            this.btn_para_4.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_proximo2;
            this.btn_para_4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_para_4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_para_4.ForeColor = System.Drawing.Color.Transparent;
            this.btn_para_4.Location = new System.Drawing.Point(751, 552);
            this.btn_para_4.Name = "btn_para_4";
            this.btn_para_4.Size = new System.Drawing.Size(90, 27);
            this.btn_para_4.TabIndex = 7;
            this.btn_para_4.UseVisualStyleBackColor = false;
            this.btn_para_4.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_volta
            // 
            this.btn_volta.BackColor = System.Drawing.Color.Transparent;
            this.btn_volta.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_voltar2;
            this.btn_volta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_volta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volta.ForeColor = System.Drawing.Color.Transparent;
            this.btn_volta.Location = new System.Drawing.Point(336, 552);
            this.btn_volta.Name = "btn_volta";
            this.btn_volta.Size = new System.Drawing.Size(90, 27);
            this.btn_volta.TabIndex = 8;
            this.btn_volta.UseVisualStyleBackColor = false;
            this.btn_volta.Click += new System.EventHandler(this.btn_volta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_sair4;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1013, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 53);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Plano3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.pag_plano3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_volta);
            this.Controls.Add(this.btn_para_4);
            this.Controls.Add(this.btn_calculadora);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_organicos);
            this.Controls.Add(this.txt_rejeitos);
            this.Controls.Add(this.txt_perigosos);
            this.Controls.Add(this.txt_reciclaveis);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Plano3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_reciclaveis;
        private System.Windows.Forms.TextBox txt_perigosos;
        private System.Windows.Forms.TextBox txt_rejeitos;
        private System.Windows.Forms.TextBox txt_organicos;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_calculadora;
        private System.Windows.Forms.Button btn_para_4;
        private System.Windows.Forms.Button btn_volta;
        private System.Windows.Forms.Button button1;
    }
}