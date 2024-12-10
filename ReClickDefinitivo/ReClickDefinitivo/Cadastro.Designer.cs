namespace ReClickDefinitivo
{
    partial class Cadastro
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
            this.btn_inserir = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.TextBox();
            this.txt_municipio = new System.Windows.Forms.TextBox();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.txt_razao_social = new System.Windows.Forms.TextBox();
            this.msk_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.msk_cep = new System.Windows.Forms.MaskedTextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(690, 467);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(75, 23);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.Text = "btn_inserir";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(387, 299);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 6;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(531, 299);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 7;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(665, 299);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 8;
            // 
            // txt_municipio
            // 
            this.txt_municipio.Location = new System.Drawing.Point(531, 391);
            this.txt_municipio.Name = "txt_municipio";
            this.txt_municipio.Size = new System.Drawing.Size(100, 20);
            this.txt_municipio.TabIndex = 9;
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(387, 480);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(100, 20);
            this.txt_uf.TabIndex = 10;
            // 
            // txt_razao_social
            // 
            this.txt_razao_social.Location = new System.Drawing.Point(531, 480);
            this.txt_razao_social.Name = "txt_razao_social";
            this.txt_razao_social.Size = new System.Drawing.Size(100, 20);
            this.txt_razao_social.TabIndex = 11;
            // 
            // msk_cnpj
            // 
            this.msk_cnpj.Location = new System.Drawing.Point(387, 391);
            this.msk_cnpj.Mask = "99.999.999/9999-99";
            this.msk_cnpj.Name = "msk_cnpj";
            this.msk_cnpj.Size = new System.Drawing.Size(110, 20);
            this.msk_cnpj.TabIndex = 12;
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(679, 391);
            this.msk_cep.Mask = "99-999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(63, 20);
            this.msk_cep.TabIndex = 13;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(690, 539);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 14;
            this.btn_login.Text = "btn_login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.b1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.msk_cep);
            this.Controls.Add(this.msk_cnpj);
            this.Controls.Add(this.txt_razao_social);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.txt_municipio);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_inserir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_telefone;
        private System.Windows.Forms.TextBox txt_municipio;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.TextBox txt_razao_social;
        private System.Windows.Forms.MaskedTextBox msk_cnpj;
        private System.Windows.Forms.MaskedTextBox msk_cep;
        private System.Windows.Forms.Button btn_login;
    }
}