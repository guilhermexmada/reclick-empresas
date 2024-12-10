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
            this.SuspendLayout();
            // 
            // btn_calculadora
            // 
            this.btn_calculadora.Location = new System.Drawing.Point(868, 107);
            this.btn_calculadora.Name = "btn_calculadora";
            this.btn_calculadora.Size = new System.Drawing.Size(75, 23);
            this.btn_calculadora.TabIndex = 2;
            this.btn_calculadora.Text = "btn_calculadora";
            this.btn_calculadora.UseVisualStyleBackColor = true;
            this.btn_calculadora.Click += new System.EventHandler(this.btn_calculadora_Click);
            // 
            // btn_lixeira
            // 
            this.btn_lixeira.Location = new System.Drawing.Point(1024, 107);
            this.btn_lixeira.Name = "btn_lixeira";
            this.btn_lixeira.Size = new System.Drawing.Size(75, 23);
            this.btn_lixeira.TabIndex = 3;
            this.btn_lixeira.Text = "btn_lixeira";
            this.btn_lixeira.UseVisualStyleBackColor = true;
            this.btn_lixeira.Click += new System.EventHandler(this.btn_lixeira_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.a1;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.btn_lixeira);
            this.Controls.Add(this.btn_calculadora);
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
    }
}