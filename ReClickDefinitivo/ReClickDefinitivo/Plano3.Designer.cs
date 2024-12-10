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
            this.SuspendLayout();
            // 
            // txt_reciclaveis
            // 
            this.txt_reciclaveis.Location = new System.Drawing.Point(259, 365);
            this.txt_reciclaveis.Name = "txt_reciclaveis";
            this.txt_reciclaveis.Size = new System.Drawing.Size(262, 20);
            this.txt_reciclaveis.TabIndex = 1;
            // 
            // txt_perigosos
            // 
            this.txt_perigosos.Location = new System.Drawing.Point(259, 491);
            this.txt_perigosos.Name = "txt_perigosos";
            this.txt_perigosos.Size = new System.Drawing.Size(262, 20);
            this.txt_perigosos.TabIndex = 2;
            // 
            // txt_rejeitos
            // 
            this.txt_rejeitos.Location = new System.Drawing.Point(629, 365);
            this.txt_rejeitos.Name = "txt_rejeitos";
            this.txt_rejeitos.Size = new System.Drawing.Size(341, 20);
            this.txt_rejeitos.TabIndex = 3;
            // 
            // txt_organicos
            // 
            this.txt_organicos.Location = new System.Drawing.Point(629, 491);
            this.txt_organicos.Name = "txt_organicos";
            this.txt_organicos.Size = new System.Drawing.Size(341, 20);
            this.txt_organicos.TabIndex = 4;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(717, 88);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 5;
            this.btn_home.Text = "btn_home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.Location = new System.Drawing.Point(881, 88);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(75, 23);
            this.btn_calculadora.TabIndex = 6;
            this.btn_calculadora.Text = "btn_calculadora";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_para_4
            // 
            this.btn_para_4.Location = new System.Drawing.Point(996, 569);
            this.btn_para_4.Name = "btn_para_4";
            this.btn_para_4.Size = new System.Drawing.Size(75, 23);
            this.btn_para_4.TabIndex = 7;
            this.btn_para_4.Text = "btn_para_4";
            this.btn_para_4.UseVisualStyleBackColor = true;
            this.btn_para_4.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_volta
            // 
            this.btn_volta.Location = new System.Drawing.Point(169, 569);
            this.btn_volta.Name = "btn_volta";
            this.btn_volta.Size = new System.Drawing.Size(75, 23);
            this.btn_volta.TabIndex = 8;
            this.btn_volta.Text = "btn_volta";
            this.btn_volta.UseVisualStyleBackColor = true;
            this.btn_volta.Click += new System.EventHandler(this.btn_volta_Click);
            // 
            // Plano3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.h;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
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
    }
}