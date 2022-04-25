namespace SDE
{
    partial class FrmCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCliente));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExlucir = new System.Windows.Forms.Button();
            this.btnnovo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listtelefone = new System.Windows.Forms.ListBox();
            this.btnexcluirtel = new System.Windows.Forms.Button();
            this.btnaddtel = new System.Windows.Forms.Button();
            this.btnlimpartel = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcep = new System.Windows.Forms.MaskedTextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtcontato = new System.Windows.Forms.TextBox();
            this.lblcontato = new System.Windows.Forms.Label();
            this.lblnome = new System.Windows.Forms.Label();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.lblrua = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.txtrua = new System.Windows.Forms.TextBox();
            this.txtbairro = new System.Windows.Forms.TextBox();
            this.lblnumero = new System.Windows.Forms.Label();
            this.lblcep = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpsqcnpj = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.txtalterar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpar.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(646, 319);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 49);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExlucir
            // 
            this.btnExlucir.BackColor = System.Drawing.SystemColors.Window;
            this.btnExlucir.BackgroundImage = global::SDE.Properties.Resources.Excluir;
            this.btnExlucir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExlucir.Location = new System.Drawing.Point(705, 319);
            this.btnExlucir.Name = "btnExlucir";
            this.btnExlucir.Size = new System.Drawing.Size(53, 49);
            this.btnExlucir.TabIndex = 60;
            this.btnExlucir.UseVisualStyleBackColor = false;
            this.btnExlucir.Click += new System.EventHandler(this.btnExlucir_Click);
            // 
            // btnnovo
            // 
            this.btnnovo.BackColor = System.Drawing.SystemColors.Window;
            this.btnnovo.BackgroundImage = global::SDE.Properties.Resources.Novo;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(528, 319);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(53, 49);
            this.btnnovo.TabIndex = 1;
            this.btnnovo.UseVisualStyleBackColor = false;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txttelefone);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listtelefone);
            this.groupBox2.Controls.Add(this.btnexcluirtel);
            this.groupBox2.Controls.Add(this.btnaddtel);
            this.groupBox2.Controls.Add(this.btnlimpartel);
            this.groupBox2.Location = new System.Drawing.Point(496, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 229);
            this.groupBox2.TabIndex = 58;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            // 
            // txttelefone
            // 
            this.txttelefone.Enabled = false;
            this.txttelefone.Location = new System.Drawing.Point(98, 49);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(119, 20);
            this.txttelefone.TabIndex = 2;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
            this.radioButton2.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(154, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(66, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Telefone";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(86, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(60, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Celular";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "*TELEFONE:";
            // 
            // listtelefone
            // 
            this.listtelefone.Enabled = false;
            this.listtelefone.FormattingEnabled = true;
            this.listtelefone.Location = new System.Drawing.Point(98, 77);
            this.listtelefone.Name = "listtelefone";
            this.listtelefone.Size = new System.Drawing.Size(119, 95);
            this.listtelefone.TabIndex = 25;
            this.listtelefone.SelectedIndexChanged += new System.EventHandler(this.listtelefone_SelectedIndexChanged);
            // 
            // btnexcluirtel
            // 
            this.btnexcluirtel.BackColor = System.Drawing.SystemColors.Window;
            this.btnexcluirtel.BackgroundImage = global::SDE.Properties.Resources.menos;
            this.btnexcluirtel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexcluirtel.Enabled = false;
            this.btnexcluirtel.Location = new System.Drawing.Point(40, 95);
            this.btnexcluirtel.Name = "btnexcluirtel";
            this.btnexcluirtel.Size = new System.Drawing.Size(35, 31);
            this.btnexcluirtel.TabIndex = 28;
            this.btnexcluirtel.UseVisualStyleBackColor = false;
            this.btnexcluirtel.Click += new System.EventHandler(this.btnexcluirtel_Click);
            // 
            // btnaddtel
            // 
            this.btnaddtel.BackColor = System.Drawing.SystemColors.Window;
            this.btnaddtel.BackgroundImage = global::SDE.Properties.Resources.Mais;
            this.btnaddtel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddtel.Enabled = false;
            this.btnaddtel.Location = new System.Drawing.Point(40, 57);
            this.btnaddtel.Name = "btnaddtel";
            this.btnaddtel.Size = new System.Drawing.Size(35, 31);
            this.btnaddtel.TabIndex = 3;
            this.btnaddtel.UseVisualStyleBackColor = false;
            this.btnaddtel.Click += new System.EventHandler(this.btnaddtel_Click);
            // 
            // btnlimpartel
            // 
            this.btnlimpartel.BackColor = System.Drawing.SystemColors.Window;
            this.btnlimpartel.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnlimpartel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpartel.Enabled = false;
            this.btnlimpartel.Location = new System.Drawing.Point(40, 132);
            this.btnlimpartel.Name = "btnlimpartel";
            this.btnlimpartel.Size = new System.Drawing.Size(35, 31);
            this.btnlimpartel.TabIndex = 27;
            this.btnlimpartel.UseVisualStyleBackColor = false;
            this.btnlimpartel.Click += new System.EventHandler(this.btnlimpartel_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalvar.BackgroundImage = global::SDE.Properties.Resources.salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(587, 319);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 49);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtcep);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtcnpj);
            this.groupBox1.Controls.Add(this.txtcontato);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblcontato);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Controls.Add(this.txtnome);
            this.groupBox1.Controls.Add(this.lblcnpj);
            this.groupBox1.Controls.Add(this.lblrua);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblcomplemento);
            this.groupBox1.Controls.Add(this.txtrua);
            this.groupBox1.Controls.Add(this.txtbairro);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Controls.Add(this.lblcep);
            this.groupBox1.Controls.Add(this.txtnumero);
            this.groupBox1.Controls.Add(this.txtComplemento);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(731, 229);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // txtcep
            // 
            this.txtcep.Location = new System.Drawing.Point(88, 108);
            this.txtcep.Mask = "00000-000";
            this.txtcep.Name = "txtcep";
            this.txtcep.Size = new System.Drawing.Size(91, 20);
            this.txtcep.TabIndex = 88;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(88, 169);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(53, 21);
            this.cmbEstado.TabIndex = 17;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(30, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 34;
            this.label4.Text = "ESTADO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Os campos com (*) são obrigatório.";
            // 
            // txtcnpj
            // 
            this.txtcnpj.Enabled = false;
            this.txtcnpj.Location = new System.Drawing.Point(88, 55);
            this.txtcnpj.Mask = "00.000.000/0000-00";
            this.txtcnpj.Name = "txtcnpj";
            this.txtcnpj.Size = new System.Drawing.Size(147, 20);
            this.txtcnpj.TabIndex = 8;
            // 
            // txtcontato
            // 
            this.txtcontato.Enabled = false;
            this.txtcontato.Location = new System.Drawing.Point(320, 51);
            this.txtcontato.Name = "txtcontato";
            this.txtcontato.Size = new System.Drawing.Size(100, 20);
            this.txtcontato.TabIndex = 9;
            // 
            // lblcontato
            // 
            this.lblcontato.AutoSize = true;
            this.lblcontato.BackColor = System.Drawing.Color.Transparent;
            this.lblcontato.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontato.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcontato.Location = new System.Drawing.Point(250, 58);
            this.lblcontato.Name = "lblcontato";
            this.lblcontato.Size = new System.Drawing.Size(69, 14);
            this.lblcontato.TabIndex = 4;
            this.lblcontato.Text = "*CONTATO:";
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblnome.Location = new System.Drawing.Point(33, 34);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(49, 14);
            this.lblnome.TabIndex = 0;
            this.lblnome.Text = "*NOME:";
            // 
            // txtnome
            // 
            this.txtnome.Enabled = false;
            this.txtnome.Location = new System.Drawing.Point(88, 28);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(355, 20);
            this.txtnome.TabIndex = 7;
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblcnpj.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnpj.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcnpj.Location = new System.Drawing.Point(43, 58);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(42, 14);
            this.lblcnpj.TabIndex = 2;
            this.lblcnpj.Text = "*CNPJ:";
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.BackColor = System.Drawing.Color.Transparent;
            this.lblrua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrua.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblrua.Location = new System.Drawing.Point(1, 82);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(85, 14);
            this.lblrua.TabIndex = 5;
            this.lblrua.Text = "*LOGADOURO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(222, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 14);
            this.label6.TabIndex = 6;
            this.label6.Text = "BAIRRO:";
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblcomplemento.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomplemento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcomplemento.Location = new System.Drawing.Point(176, 145);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(97, 14);
            this.lblcomplemento.TabIndex = 7;
            this.lblcomplemento.Text = "COMPLEMENTO:";
            // 
            // txtrua
            // 
            this.txtrua.Enabled = false;
            this.txtrua.Location = new System.Drawing.Point(88, 79);
            this.txtrua.Name = "txtrua";
            this.txtrua.Size = new System.Drawing.Size(332, 20);
            this.txtrua.TabIndex = 10;
            // 
            // txtbairro
            // 
            this.txtbairro.Enabled = false;
            this.txtbairro.Location = new System.Drawing.Point(279, 106);
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.Size = new System.Drawing.Size(100, 20);
            this.txtbairro.TabIndex = 12;
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblnumero.Location = new System.Drawing.Point(22, 138);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(64, 14);
            this.lblnumero.TabIndex = 15;
            this.lblnumero.Text = "*NUMERO:";
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.BackColor = System.Drawing.Color.Transparent;
            this.lblcep.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcep.Location = new System.Drawing.Point(49, 110);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(37, 14);
            this.lblcep.TabIndex = 16;
            this.lblcep.Text = "*CEP:";
            // 
            // txtnumero
            // 
            this.txtnumero.Enabled = false;
            this.txtnumero.Location = new System.Drawing.Point(88, 134);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(53, 20);
            this.txtnumero.TabIndex = 13;
            // 
            // txtComplemento
            // 
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(279, 139);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(85, 20);
            this.txtComplemento.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.txtpsqcnpj);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(248, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 47);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::SDE.Properties.Resources.Pesquisar;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(254, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 29);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpsqcnpj
            // 
            this.txtpsqcnpj.Location = new System.Drawing.Point(101, 14);
            this.txtpsqcnpj.Mask = "00.000.000/0000-00";
            this.txtpsqcnpj.Name = "txtpsqcnpj";
            this.txtpsqcnpj.Size = new System.Drawing.Size(147, 20);
            this.txtpsqcnpj.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(53, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 14);
            this.label2.TabIndex = 0;
            this.label2.Text = "CNPJ:";
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(25, 375);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(731, 196);
            this.dgvCliente.TabIndex = 66;
            this.dgvCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellContentClick);
            // 
            // txtalterar
            // 
            this.txtalterar.BackgroundImage = global::SDE.Properties.Resources.alterar;
            this.txtalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtalterar.Location = new System.Drawing.Point(473, 319);
            this.txtalterar.Name = "txtalterar";
            this.txtalterar.Size = new System.Drawing.Size(49, 49);
            this.txtalterar.TabIndex = 67;
            this.txtalterar.UseVisualStyleBackColor = true;
            this.txtalterar.Click += new System.EventHandler(this.txtalterar_Click);
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.txtalterar);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnExlucir);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExlucir;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listtelefone;
        private System.Windows.Forms.Button btnexcluirtel;
        private System.Windows.Forms.Button btnaddtel;
        private System.Windows.Forms.Button btnlimpartel;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox txtcnpj;
        private System.Windows.Forms.TextBox txtcontato;
        private System.Windows.Forms.Label lblcontato;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.TextBox txtrua;
        private System.Windows.Forms.TextBox txtbairro;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.TextBox txtnumero;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtpsqcnpj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button txtalterar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.MaskedTextBox txtcep;
    }
}