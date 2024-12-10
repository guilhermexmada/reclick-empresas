namespace ReClickDefinitivo
{
    partial class Plano2
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
            this.txt_calculo = new System.Windows.Forms.TextBox();
            this.txt_projeto = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.btn_para_3 = new System.Windows.Forms.Button();
            this.btn_volta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_calculo
            // 
            this.txt_calculo.Location = new System.Drawing.Point(328, 358);
            this.txt_calculo.Name = "txt_calculo";
            this.txt_calculo.Size = new System.Drawing.Size(429, 20);
            this.txt_calculo.TabIndex = 1;
            // 
            // txt_projeto
            // 
            this.txt_projeto.Location = new System.Drawing.Point(328, 465);
            this.txt_projeto.Name = "txt_projeto";
            this.txt_projeto.Size = new System.Drawing.Size(429, 20);
            this.txt_projeto.TabIndex = 2;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(725, 89);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 3;
            this.btn_home.Text = "btn_home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.Location = new System.Drawing.Point(883, 89);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(75, 23);
            this.btn_calculadora.TabIndex = 5;
            this.btn_calculadora.Text = "btn_calculadora";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_para_3
            // 
            this.btn_para_3.Location = new System.Drawing.Point(841, 539);
            this.btn_para_3.Name = "btn_para_3";
            this.btn_para_3.Size = new System.Drawing.Size(75, 23);
            this.btn_para_3.TabIndex = 6;
            this.btn_para_3.Text = "btn_para_3";
            this.btn_para_3.UseVisualStyleBackColor = true;
            this.btn_para_3.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_volta
            // 
            this.btn_volta.Location = new System.Drawing.Point(223, 539);
            this.btn_volta.Name = "btn_volta";
            this.btn_volta.Size = new System.Drawing.Size(75, 23);
            this.btn_volta.TabIndex = 7;
            this.btn_volta.Text = "btn_volta";
            this.btn_volta.UseVisualStyleBackColor = true;
            this.btn_volta.Click += new System.EventHandler(this.btn_volta_Click);
            // 
            // Plano2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.f1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.btn_volta);
            this.Controls.Add(this.btn_para_3);
            this.Controls.Add(this.btn_calculadora);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.txt_projeto);
            this.Controls.Add(this.txt_calculo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Plano2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plano2";
            this.Load += new System.EventHandler(this.Plano2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_calculo;
        private System.Windows.Forms.TextBox txt_projeto;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_calculadora;
        private System.Windows.Forms.Button btn_para_3;
        private System.Windows.Forms.Button btn_volta;
    }
}