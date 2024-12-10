namespace ReClickDefinitivo
{
    partial class Calculadora
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btn_plano = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txt_rejeitos = new System.Windows.Forms.TextBox();
            this.txt_rejeitos_organicos = new System.Windows.Forms.TextBox();
            this.txt_rejeitos_reciclaveis = new System.Windows.Forms.TextBox();
            this.txt_rejeitos_perigosos = new System.Windows.Forms.TextBox();
            this.txt_agua = new System.Windows.Forms.TextBox();
            this.txt_energia = new System.Windows.Forms.TextBox();
            this.cht_Gastos = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btn_Gerar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_registros = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cht_Gastos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_plano
            // 
            this.btn_plano.BackColor = System.Drawing.Color.Transparent;
            this.btn_plano.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_pgrs;
            this.btn_plano.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_plano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plano.ForeColor = System.Drawing.Color.Transparent;
            this.btn_plano.Location = new System.Drawing.Point(468, 547);
            this.btn_plano.Name = "btn_plano";
            this.btn_plano.Size = new System.Drawing.Size(119, 37);
            this.btn_plano.TabIndex = 2;
            this.btn_plano.UseVisualStyleBackColor = false;
            this.btn_plano.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_home;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(700, 76);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 58);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_lixeira1;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Transparent;
            this.button4.Location = new System.Drawing.Point(859, 76);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 58);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_sair1;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(1012, 76);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 58);
            this.button5.TabIndex = 5;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // txt_rejeitos
            // 
            this.txt_rejeitos.Location = new System.Drawing.Point(214, 297);
            this.txt_rejeitos.Name = "txt_rejeitos";
            this.txt_rejeitos.Size = new System.Drawing.Size(91, 20);
            this.txt_rejeitos.TabIndex = 6;
            // 
            // txt_rejeitos_organicos
            // 
            this.txt_rejeitos_organicos.Location = new System.Drawing.Point(407, 297);
            this.txt_rejeitos_organicos.Name = "txt_rejeitos_organicos";
            this.txt_rejeitos_organicos.Size = new System.Drawing.Size(91, 20);
            this.txt_rejeitos_organicos.TabIndex = 7;
            this.txt_rejeitos_organicos.TextChanged += new System.EventHandler(this.txt_rejeitos_organicos_TextChanged);
            // 
            // txt_rejeitos_reciclaveis
            // 
            this.txt_rejeitos_reciclaveis.Location = new System.Drawing.Point(214, 396);
            this.txt_rejeitos_reciclaveis.Name = "txt_rejeitos_reciclaveis";
            this.txt_rejeitos_reciclaveis.Size = new System.Drawing.Size(91, 20);
            this.txt_rejeitos_reciclaveis.TabIndex = 8;
            // 
            // txt_rejeitos_perigosos
            // 
            this.txt_rejeitos_perigosos.Location = new System.Drawing.Point(407, 396);
            this.txt_rejeitos_perigosos.Name = "txt_rejeitos_perigosos";
            this.txt_rejeitos_perigosos.Size = new System.Drawing.Size(91, 20);
            this.txt_rejeitos_perigosos.TabIndex = 9;
            // 
            // txt_agua
            // 
            this.txt_agua.Location = new System.Drawing.Point(214, 480);
            this.txt_agua.Name = "txt_agua";
            this.txt_agua.Size = new System.Drawing.Size(91, 20);
            this.txt_agua.TabIndex = 10;
            // 
            // txt_energia
            // 
            this.txt_energia.Location = new System.Drawing.Point(407, 480);
            this.txt_energia.Name = "txt_energia";
            this.txt_energia.Size = new System.Drawing.Size(91, 20);
            this.txt_energia.TabIndex = 11;
            // 
            // cht_Gastos
            // 
            this.cht_Gastos.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.Name = "ChartArea1";
            this.cht_Gastos.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cht_Gastos.Legends.Add(legend1);
            this.cht_Gastos.Location = new System.Drawing.Point(660, 263);
            this.cht_Gastos.Name = "cht_Gastos";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.cht_Gastos.Series.Add(series1);
            this.cht_Gastos.Size = new System.Drawing.Size(445, 300);
            this.cht_Gastos.TabIndex = 12;
            this.cht_Gastos.Text = "chart1";
            this.cht_Gastos.Click += new System.EventHandler(this.cht_Gastos_Click);
            // 
            // btn_Gerar
            // 
            this.btn_Gerar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Gerar.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_gerar_grafico;
            this.btn_Gerar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Gerar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Gerar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Gerar.Location = new System.Drawing.Point(295, 547);
            this.btn_Gerar.Name = "btn_Gerar";
            this.btn_Gerar.Size = new System.Drawing.Size(119, 37);
            this.btn_Gerar.TabIndex = 13;
            this.btn_Gerar.UseVisualStyleBackColor = false;
            this.btn_Gerar.Click += new System.EventHandler(this.btn_Gerar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(361, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_registros
            // 
            this.cmb_registros.FormattingEnabled = true;
            this.cmb_registros.Location = new System.Drawing.Point(928, 206);
            this.cmb_registros.Name = "cmb_registros";
            this.cmb_registros.Size = new System.Drawing.Size(121, 21);
            this.cmb_registros.TabIndex = 16;
            this.cmb_registros.SelectedIndexChanged += new System.EventHandler(this.cmb_registros_SelectedIndexChanged);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Transparent;
            this.btn_salvar.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.btn_salvar;
            this.btn_salvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.ForeColor = System.Drawing.Color.Transparent;
            this.btn_salvar.Location = new System.Drawing.Point(126, 547);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(113, 37);
            this.btn_salvar.TabIndex = 17;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ReClickDefinitivo.Properties.Resources.pag_gerenciar;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1195, 669);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.cmb_registros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Gerar);
            this.Controls.Add(this.cht_Gastos);
            this.Controls.Add(this.txt_energia);
            this.Controls.Add(this.txt_agua);
            this.Controls.Add(this.txt_rejeitos_perigosos);
            this.Controls.Add(this.txt_rejeitos_reciclaveis);
            this.Controls.Add(this.txt_rejeitos_organicos);
            this.Controls.Add(this.txt_rejeitos);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_plano);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Calculadora_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cht_Gastos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_plano;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txt_rejeitos;
        private System.Windows.Forms.TextBox txt_rejeitos_organicos;
        private System.Windows.Forms.TextBox txt_rejeitos_reciclaveis;
        private System.Windows.Forms.TextBox txt_rejeitos_perigosos;
        private System.Windows.Forms.TextBox txt_agua;
        private System.Windows.Forms.TextBox txt_energia;
        private System.Windows.Forms.DataVisualization.Charting.Chart cht_Gastos;
        private System.Windows.Forms.Button btn_Gerar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_registros;
        private System.Windows.Forms.Button btn_salvar;
    }
}