namespace SDE
{
    partial class FrmConsultaCli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultaCli));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtpsqnome = new System.Windows.Forms.TextBox();
            this.cmb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpsqcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtalterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExlucir = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.txtpsqnome);
            this.groupBox3.Controls.Add(this.cmb);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtpsqcnpj);
            this.groupBox3.Location = new System.Drawing.Point(137, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 43);
            this.groupBox3.TabIndex = 69;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // txtpsqnome
            // 
            this.txtpsqnome.Location = new System.Drawing.Point(229, 12);
            this.txtpsqnome.Name = "txtpsqnome";
            this.txtpsqnome.Size = new System.Drawing.Size(147, 20);
            this.txtpsqnome.TabIndex = 81;
            this.txtpsqnome.TextChanged += new System.EventHandler(this.txtpsqnome_TextChanged);
            // 
            // cmb
            // 
            this.cmb.FormattingEnabled = true;
            this.cmb.Items.AddRange(new object[] {
            "NOME",
            "CNPJ",
            "CPF"});
            this.cmb.Location = new System.Drawing.Point(87, 13);
            this.cmb.Name = "cmb";
            this.cmb.Size = new System.Drawing.Size(121, 21);
            this.cmb.TabIndex = 81;
            this.cmb.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SDE.Properties.Resources._1392271216_Search;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(382, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 31);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpsqcnpj
            // 
            this.txtpsqcnpj.Location = new System.Drawing.Point(229, 12);
            this.txtpsqcnpj.Mask = "00.000.000/0000-00";
            this.txtpsqcnpj.Name = "txtpsqcnpj";
            this.txtpsqcnpj.Size = new System.Drawing.Size(147, 20);
            this.txtpsqcnpj.TabIndex = 1;
            // 
            // txtalterar
            // 
            this.txtalterar.BackgroundImage = global::SDE.Properties.Resources.alterar;
            this.txtalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtalterar.Location = new System.Drawing.Point(273, 388);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(49, 46);
            this.txtalterar.TabIndex = 80;
            this.txtalterar.UseVisualStyleBackColor = true;
            this.txtalterar.Click += new System.EventHandler(this.txtalterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(389, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 46);
            this.btnLimpar.TabIndex = 76;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExlucir
            // 
            this.btnExlucir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExlucir.BackgroundImage = global::SDE.Properties.Resources.Excluir;
            this.btnExlucir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExlucir.Location = new System.Drawing.Point(448, 388);
            this.btnExlucir.Name = "btnExlucir";
            this.btnExlucir.Size = new System.Drawing.Size(53, 46);
            this.btnExlucir.TabIndex = 77;
            this.btnExlucir.UseVisualStyleBackColor = false;
            this.btnExlucir.Click += new System.EventHandler(this.btnExlucir_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnnovo.BackgroundImage = global::SDE.Properties.Resources.Novo;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(328, 388);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(53, 46);
            this.btnnovo.TabIndex = 79;
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(75, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(581, 251);
            this.dataGridView1.TabIndex = 81;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FrmConsultaCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.ClientSize = new System.Drawing.Size(764, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExlucir);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.groupBox3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmConsultaCli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.FrmConsultaCli_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtpsqcnpj;
        private System.Windows.Forms.ComboBox cmb;
        private System.Windows.Forms.Button txtalterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExlucir;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.TextBox txtpsqnome;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}