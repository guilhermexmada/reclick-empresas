namespace ReClickDefinitivo
{
    partial class Home
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
            this.btn_calculadora = new System.Windows.Forms.Button();
            this.btn_lixeira = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.BackColor = System.Drawing.Color.Transparent;
            this.btn_calculadora.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_gerenciar;
            this.btn_calculadora.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_calculadora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calculadora.ForeColor = System.Drawing.Color.Transparent;
            this.btn_calculadora.Location = new System.Drawing.Point(698, 78);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(118, 52);
            this.btn_calculadora.TabIndex = 2;
            this.btn_calculadora.UseVisualStyleBackColor = false;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_lixeira
            // 
            this.btn_lixeira.BackColor = System.Drawing.Color.Transparent;
            this.btn_lixeira.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_lixeira;
            this.btn_lixeira.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_lixeira.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_lixeira.ForeColor = System.Drawing.Color.Transparent;
            this.btn_lixeira.Location = new System.Drawing.Point(858, 78);
            this.btn_lixeira.Name = "btn_lixeira";
            this.btn_lixeira.Size = new System.Drawing.Size(115, 52);
            this.btn_lixeira.TabIndex = 3;
            this.btn_lixeira.UseVisualStyleBackColor = false;
            this.btn_lixeira.Click += new System.EventHandler(this.btn_lixeira_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Transparent;
            this.btn_sair.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_sair;
            this.btn_sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.ForeColor = System.Drawing.Color.Transparent;
            this.btn_sair.Location = new System.Drawing.Point(1014, 78);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(115, 52);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.pag_home;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_lixeira);
            this.Controls.Add(this.btn_calculadora);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_calculadora;
        private System.Windows.Forms.Button btn_lixeira;
        private System.Windows.Forms.Button btn_sair;
    }
}