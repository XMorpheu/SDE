namespace SDE
{
    partial class FrmVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVeiculo));
            this.dgvVeiculo = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmodelo = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtmarca = new System.Windows.Forms.ComboBox();
            this.txtcor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtplaca = new System.Windows.Forms.MaskedTextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.txtrodizio = new System.Windows.Forms.TextBox();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.lblcontato = new System.Windows.Forms.Label();
            this.txtchassi = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExlucir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtpesquisaplaca = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvVeiculo
            // 
            this.dgvVeiculo.AllowUserToAddRows = false;
            this.dgvVeiculo.AllowUserToDeleteRows = false;
            this.dgvVeiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculo.Location = new System.Drawing.Point(135, 284);
            this.dgvVeiculo.Name = "dgvVeiculo";
            this.dgvVeiculo.ReadOnly = true;
            this.dgvVeiculo.Size = new System.Drawing.Size(534, 150);
            this.dgvVeiculo.TabIndex = 62;
            this.dgvVeiculo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVeiculo_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtmodelo);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Controls.Add(this.txtcor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtplaca);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.lblcnpj);
            this.groupBox1.Controls.Add(this.txtrodizio);
            this.groupBox1.Controls.Add(this.lblcomplemento);
            this.groupBox1.Controls.Add(this.lblcontato);
            this.groupBox1.Controls.Add(this.txtchassi);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(125, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 125);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veículo";
            // 
            // txtmodelo
            // 
            this.txtmodelo.FormattingEnabled = true;
            this.txtmodelo.Items.AddRange(new object[] {
            "M1313",
            "M1413",
            "F1330",
            "F1513"});
            this.txtmodelo.Location = new System.Drawing.Point(242, 32);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(87, 21);
            this.txtmodelo.TabIndex = 75;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(491, 80);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 74;
            this.button2.Text = "Rodízio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Enabled = false;
            this.txtmarca.FormattingEnabled = true;
            this.txtmarca.Location = new System.Drawing.Point(68, 30);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(70, 21);
            this.txtmarca.TabIndex = 73;
            // 
            // txtcor
            // 
            this.txtcor.Enabled = false;
            this.txtcor.FormattingEnabled = true;
            this.txtcor.Location = new System.Drawing.Point(242, 58);
            this.txtcor.Name = "txtcor";
            this.txtcor.Size = new System.Drawing.Size(87, 21);
            this.txtcor.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Os campos com (*) são obrigatório.";
            // 
            // txtplaca
            // 
            this.txtplaca.Enabled = false;
            this.txtplaca.Location = new System.Drawing.Point(61, 58);
            this.txtplaca.Mask = "aaa-0000";
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(100, 20);
            this.txtplaca.TabIndex = 50;
            this.txtplaca.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtplaca_MaskInputRejected);
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblnome.Location = new System.Drawing.Point(8, 32);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(59, 15);
            this.lblnome.TabIndex = 29;
            this.lblnome.Text = "*MARCA:";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblcnpj.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnpj.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcnpj.Location = new System.Drawing.Point(171, 35);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(69, 15);
            this.lblcnpj.TabIndex = 31;
            this.lblcnpj.Text = "*MODELO:";
            // 
            // txtrodizio
            // 
            this.txtrodizio.Enabled = false;
            this.txtrodizio.Location = new System.Drawing.Point(447, 54);
            this.txtrodizio.Name = "txtrodizio";
            this.txtrodizio.Size = new System.Drawing.Size(97, 20);
            this.txtrodizio.TabIndex = 43;
            this.txtrodizio.TextChanged += new System.EventHandler(this.txtrodizio_TextChanged);
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblcomplemento.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomplemento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcomplemento.Location = new System.Drawing.Point(337, 61);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(111, 15);
            this.lblcomplemento.TabIndex = 35;
            this.lblcomplemento.Text = "*DIA DE RODIZIO:";
            // 
            // lblcontato
            // 
            this.lblcontato.AutoSize = true;
            this.lblcontato.BackColor = System.Drawing.Color.Transparent;
            this.lblcontato.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontato.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcontato.Location = new System.Drawing.Point(8, 62);
            this.lblcontato.Name = "lblcontato";
            this.lblcontato.Size = new System.Drawing.Size(54, 15);
            this.lblcontato.TabIndex = 32;
            this.lblcontato.Text = "*PLACA:";
            // 
            // txtchassi
            // 
            this.txtchassi.Enabled = false;
            this.txtchassi.Location = new System.Drawing.Point(447, 29);
            this.txtchassi.Name = "txtchassi";
            this.txtchassi.Size = new System.Drawing.Size(97, 20);
            this.txtchassi.TabIndex = 42;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblnumero.Location = new System.Drawing.Point(335, 33);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(114, 15);
            this.lblnumero.TabIndex = 40;
            this.lblnumero.Text = "*NUMERO CHASSI:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(199, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 48;
            this.label1.Text = "*COR:";
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = global::SDE.Properties.Resources.Novo;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(454, 219);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(53, 46);
            this.btnnovo.TabIndex = 60;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SDE.Properties.Resources.salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(513, 219);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 46);
            this.btnSalvar.TabIndex = 59;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExlucir
            // 
            this.btnExlucir.BackgroundImage = global::SDE.Properties.Resources.Excluir;
            this.btnExlucir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExlucir.Location = new System.Drawing.Point(631, 219);
            this.btnExlucir.Name = "btnExlucir";
            this.btnExlucir.Size = new System.Drawing.Size(53, 46);
            this.btnExlucir.TabIndex = 58;
            this.btnExlucir.UseVisualStyleBackColor = true;
            this.btnExlucir.Click += new System.EventHandler(this.btnExlucir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(572, 219);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 46);
            this.btnLimpar.TabIndex = 57;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtpesquisaplaca);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(252, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 43);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // txtpesquisaplaca
            // 
            this.txtpesquisaplaca.Location = new System.Drawing.Point(106, 13);
            this.txtpesquisaplaca.Mask = "aaa-0000";
            this.txtpesquisaplaca.Name = "txtpesquisaplaca";
            this.txtpesquisaplaca.Size = new System.Drawing.Size(119, 20);
            this.txtpesquisaplaca.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SDE.Properties.Resources.Pesquisar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(244, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(53, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "PLACA :";
            // 
            // btnalterar
            // 
            this.btnalterar.BackgroundImage = global::SDE.Properties.Resources.alterar;
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalterar.Location = new System.Drawing.Point(399, 219);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(49, 46);
            this.btnalterar.TabIndex = 72;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // FrmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvVeiculo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExlucir);
            this.Controls.Add(this.btnLimpar);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVeiculo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Veiculo";
            this.Load += new System.EventHandler(this.FrmVeiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVeiculo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtplaca;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.TextBox txtrodizio;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label lblcontato;
        private System.Windows.Forms.TextBox txtchassi;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExlucir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox txtpesquisaplaca;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtcor;
        private System.Windows.Forms.ComboBox txtmarca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox txtmodelo;
    }
}