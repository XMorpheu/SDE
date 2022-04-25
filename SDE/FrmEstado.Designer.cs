namespace SDE
{
    partial class FrmEstado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstado));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtestado = new System.Windows.Forms.MaskedTextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExlucir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtpesquisar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Location = new System.Drawing.Point(103, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(313, 125);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(116, 52);
            this.txtestado.Mask = "AA";
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(119, 20);
            this.txtestado.TabIndex = 30;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblnome.Location = new System.Drawing.Point(73, 54);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(27, 15);
            this.lblnome.TabIndex = 29;
            this.lblnome.Text = "UF:";
            // 
            // btnalterar
            // 
            this.btnalterar.BackgroundImage = global::SDE.Properties.Resources.alterar;
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalterar.Location = new System.Drawing.Point(111, 188);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(49, 46);
            this.btnalterar.TabIndex = 77;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.btnalterar_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = global::SDE.Properties.Resources.Novo;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(166, 188);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(53, 46);
            this.btnnovo.TabIndex = 76;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SDE.Properties.Resources.salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(225, 188);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 46);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExlucir
            // 
            this.btnExlucir.BackgroundImage = global::SDE.Properties.Resources.Excluir;
            this.btnExlucir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExlucir.Location = new System.Drawing.Point(343, 188);
            this.btnExlucir.Name = "btnExlucir";
            this.btnExlucir.Size = new System.Drawing.Size(53, 46);
            this.btnExlucir.TabIndex = 74;
            this.btnExlucir.UseVisualStyleBackColor = true;
            this.btnExlucir.Click += new System.EventHandler(this.btnExlucir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(284, 188);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 46);
            this.btnLimpar.TabIndex = 73;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(103, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(313, 124);
            this.dataGridView1.TabIndex = 78;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.txtpesquisar);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(47, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(421, 43);
            this.groupBox3.TabIndex = 79;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.Location = new System.Drawing.Point(150, 16);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(118, 20);
            this.txtpesquisar.TabIndex = 1;
            this.txtpesquisar.TextChanged += new System.EventHandler(this.txtpesquisar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(116, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "UF:";
            // 
            // FrmEstado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(514, 411);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExlucir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmEstado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estado";
            this.Load += new System.EventHandler(this.FrmEstado_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.MaskedTextBox txtestado;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExlucir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpesquisar;
    }
}