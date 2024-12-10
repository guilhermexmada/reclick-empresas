namespace ReClickDefinitivo
{
    partial class Entrar
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_cadastro = new System.Windows.Forms.Button();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.msk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(557, 450);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_cadastro
            // 
            this.btn_cadastro.Location = new System.Drawing.Point(557, 511);
            this.btn_cadastro.Name = "btn_cadastro";
            this.btn_cadastro.Size = new System.Drawing.Size(89, 23);
            this.btn_cadastro.TabIndex = 1;
            this.btn_cadastro.Text = "btn_cadastro";
            this.btn_cadastro.UseVisualStyleBackColor = true;
            this.btn_cadastro.Click += new System.EventHandler(this.btn_cadastro_Click);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(528, 300);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(139, 20);
            this.txt_email.TabIndex = 5;
            // 
            // msk_cnpj
            // 
            this.msk_cnpj.Location = new System.Drawing.Point(542, 396);
            this.msk_cnpj.Mask = "99.999.999/9999-99";
            this.msk_cnpj.Name = "msk_cnpj";
            this.msk_cnpj.Size = new System.Drawing.Size(104, 20);
            this.msk_cnpj.TabIndex = 6;
            // 
            // Entrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.C1;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.msk_cnpj);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.btn_cadastro);
            this.Controls.Add(this.btn_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Entrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_cadastro;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox msk_cnpj;
    }
}