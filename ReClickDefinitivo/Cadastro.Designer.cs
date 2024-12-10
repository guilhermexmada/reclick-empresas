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
            this.btn_inserir.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_cadastrar2;
            this.btn_inserir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inserir.ForeColor = System.Drawing.Color.Transparent;
            this.btn_inserir.Location = new System.Drawing.Point(678, 464);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(117, 28);
            this.btn_inserir.TabIndex = 1;
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(391, 299);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(100, 20);
            this.txt_nome.TabIndex = 6;
            this.txt_nome.TextChanged += new System.EventHandler(this.txt_nome_TextChanged);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(538, 299);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 7;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // txt_telefone
            // 
            this.txt_telefone.Location = new System.Drawing.Point(683, 299);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_telefone.TabIndex = 8;
            this.txt_telefone.TextChanged += new System.EventHandler(this.txt_telefone_TextChanged);
            // 
            // txt_municipio
            // 
            this.txt_municipio.Location = new System.Drawing.Point(538, 391);
            this.txt_municipio.Name = "txt_municipio";
            this.txt_municipio.Size = new System.Drawing.Size(100, 20);
            this.txt_municipio.TabIndex = 9;
            this.txt_municipio.TextChanged += new System.EventHandler(this.txt_municipio_TextChanged);
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(391, 485);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(73, 20);
            this.txt_uf.TabIndex = 10;
            this.txt_uf.TextChanged += new System.EventHandler(this.txt_uf_TextChanged);
            // 
            // txt_razao_social
            // 
            this.txt_razao_social.Location = new System.Drawing.Point(538, 485);
            this.txt_razao_social.Name = "txt_razao_social";
            this.txt_razao_social.Size = new System.Drawing.Size(100, 20);
            this.txt_razao_social.TabIndex = 11;
            this.txt_razao_social.TextChanged += new System.EventHandler(this.txt_razao_social_TextChanged);
            // 
            // msk_cnpj
            // 
            this.msk_cnpj.Location = new System.Drawing.Point(391, 391);
            this.msk_cnpj.Mask = "99.999.999/9999-99";
            this.msk_cnpj.Name = "msk_cnpj";
            this.msk_cnpj.Size = new System.Drawing.Size(110, 20);
            this.msk_cnpj.TabIndex = 12;
            this.msk_cnpj.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_cnpj_MaskInputRejected);
            // 
            // msk_cep
            // 
            this.msk_cep.Location = new System.Drawing.Point(694, 391);
            this.msk_cep.Mask = "99-999-999";
            this.msk_cep.Name = "msk_cep";
            this.msk_cep.Size = new System.Drawing.Size(63, 20);
            this.msk_cep.TabIndex = 13;
            this.msk_cep.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.msk_cep_MaskInputRejected);
            // 
            // btn_login
            // 
            this.btn_login.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_entrar2;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.Transparent;
            this.btn_login.Location = new System.Drawing.Point(678, 513);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(117, 28);
            this.btn_login.TabIndex = 14;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.pag_cadastro;
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
            this.Controls.Add(this.btn_inserir);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inserir;
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