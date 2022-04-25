namespace SDE
{
    partial class FrmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFuncionario));
            this.dgvfuncionario = new System.Windows.Forms.DataGridView();
            this.btnnovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExlucir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcepfunc = new System.Windows.Forms.MaskedTextBox();
            this.txtcargo = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcnh = new System.Windows.Forms.ComboBox();
            this.txtnascfunc = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtcpffunc = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttelefone = new System.Windows.Forms.MaskedTextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.listtelefone = new System.Windows.Forms.ListBox();
            this.btnexcluirtel = new System.Windows.Forms.Button();
            this.btnaddtel = new System.Windows.Forms.Button();
            this.btnlimpartel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtfuncaofunc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComplementofunc = new System.Windows.Forms.TextBox();
            this.txtnumerofunc = new System.Windows.Forms.TextBox();
            this.lblcep = new System.Windows.Forms.Label();
            this.lblnumero = new System.Windows.Forms.Label();
            this.txtbairrofunc = new System.Windows.Forms.TextBox();
            this.txtruafunc = new System.Windows.Forms.TextBox();
            this.lblcomplemento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblrua = new System.Windows.Forms.Label();
            this.lblcnpj = new System.Windows.Forms.Label();
            this.txtnomefunc = new System.Windows.Forms.TextBox();
            this.lblnome = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.mskpesquisar = new System.Windows.Forms.MaskedTextBox();
            this.txtpesquisar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnalterar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvfuncionario
            // 
            this.dgvfuncionario.AllowUserToAddRows = false;
            this.dgvfuncionario.AllowUserToDeleteRows = false;
            this.dgvfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfuncionario.Location = new System.Drawing.Point(41, 405);
            this.dgvfuncionario.Name = "dgvfuncionario";
            this.dgvfuncionario.ReadOnly = true;
            this.dgvfuncionario.Size = new System.Drawing.Size(689, 156);
            this.dgvfuncionario.TabIndex = 69;
            this.dgvfuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfuncionario_CellContentClick);
            // 
            // btnnovo
            // 
            this.btnnovo.BackgroundImage = global::SDE.Properties.Resources.Novo;
            this.btnnovo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnovo.Location = new System.Drawing.Point(500, 352);
            this.btnnovo.Name = "btnnovo";
            this.btnnovo.Size = new System.Drawing.Size(53, 49);
            this.btnnovo.TabIndex = 68;
            this.btnnovo.UseVisualStyleBackColor = true;
            this.btnnovo.Click += new System.EventHandler(this.btnnovo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackgroundImage = global::SDE.Properties.Resources.salvar;
            this.btnSalvar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalvar.Location = new System.Drawing.Point(559, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 49);
            this.btnSalvar.TabIndex = 67;
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExlucir
            // 
            this.btnExlucir.BackgroundImage = global::SDE.Properties.Resources.Excluir;
            this.btnExlucir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExlucir.Location = new System.Drawing.Point(677, 352);
            this.btnExlucir.Name = "btnExlucir";
            this.btnExlucir.Size = new System.Drawing.Size(53, 49);
            this.btnExlucir.TabIndex = 66;
            this.btnExlucir.UseVisualStyleBackColor = true;
            this.btnExlucir.Click += new System.EventHandler(this.Exlucir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLimpar.Location = new System.Drawing.Point(618, 352);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 49);
            this.btnLimpar.TabIndex = 65;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtcepfunc);
            this.groupBox1.Controls.Add(this.txtcargo);
            this.groupBox1.Controls.Add(this.cmbEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcnh);
            this.groupBox1.Controls.Add(this.txtnascfunc);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtcpffunc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtfuncaofunc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtComplementofunc);
            this.groupBox1.Controls.Add(this.txtnumerofunc);
            this.groupBox1.Controls.Add(this.lblcep);
            this.groupBox1.Controls.Add(this.lblnumero);
            this.groupBox1.Controls.Add(this.txtbairrofunc);
            this.groupBox1.Controls.Add(this.txtruafunc);
            this.groupBox1.Controls.Add(this.lblcomplemento);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblrua);
            this.groupBox1.Controls.Add(this.lblcnpj);
            this.groupBox1.Controls.Add(this.txtnomefunc);
            this.groupBox1.Controls.Add(this.lblnome);
            this.groupBox1.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 282);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Funcionário";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtcepfunc
            // 
            this.txtcepfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcepfunc.Location = new System.Drawing.Point(82, 89);
            this.txtcepfunc.Mask = "00000-000";
            this.txtcepfunc.Name = "txtcepfunc";
            this.txtcepfunc.Size = new System.Drawing.Size(91, 20);
            this.txtcepfunc.TabIndex = 87;
            // 
            // txtcargo
            // 
            this.txtcargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcargo.FormattingEnabled = true;
            this.txtcargo.Location = new System.Drawing.Point(82, 120);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(107, 21);
            this.txtcargo.TabIndex = 7;
            // 
            // cmbEstado
            // 
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(394, 89);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(82, 21);
            this.cmbEstado.TabIndex = 11;
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.cmbEstado_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(345, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 14);
            this.label9.TabIndex = 86;
            this.label9.Text = "ESTADO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(58, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(178, 15);
            this.label8.TabIndex = 85;
            this.label8.Text = "Os campos com (*) são obrigatório.";
            // 
            // txtcnh
            // 
            this.txtcnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcnh.FormattingEnabled = true;
            this.txtcnh.Location = new System.Drawing.Point(338, 156);
            this.txtcnh.Name = "txtcnh";
            this.txtcnh.Size = new System.Drawing.Size(67, 21);
            this.txtcnh.TabIndex = 10;
            // 
            // txtnascfunc
            // 
            this.txtnascfunc.Enabled = false;
            this.txtnascfunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnascfunc.Location = new System.Drawing.Point(338, 121);
            this.txtnascfunc.Mask = "00/00/0000";
            this.txtnascfunc.Name = "txtnascfunc";
            this.txtnascfunc.Size = new System.Drawing.Size(78, 20);
            this.txtnascfunc.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(302, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 14);
            this.label7.TabIndex = 81;
            this.label7.Text = "CNH";
            // 
            // txtcpffunc
            // 
            this.txtcpffunc.Enabled = false;
            this.txtcpffunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcpffunc.Location = new System.Drawing.Point(509, 32);
            this.txtcpffunc.Mask = "000.000.000-00";
            this.txtcpffunc.Name = "txtcpffunc";
            this.txtcpffunc.Size = new System.Drawing.Size(91, 20);
            this.txtcpffunc.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(3, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 14);
            this.label5.TabIndex = 78;
            this.label5.Text = "*CARGO:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txttelefone);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.listtelefone);
            this.groupBox2.Controls.Add(this.btnexcluirtel);
            this.groupBox2.Controls.Add(this.btnaddtel);
            this.groupBox2.Controls.Add(this.btnlimpartel);
            this.groupBox2.Location = new System.Drawing.Point(477, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 193);
            this.groupBox2.TabIndex = 77;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Contato";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txttelefone
            // 
            this.txttelefone.Enabled = false;
            this.txttelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefone.Location = new System.Drawing.Point(98, 49);
            this.txttelefone.Name = "txttelefone";
            this.txttelefone.Size = new System.Drawing.Size(119, 20);
            this.txttelefone.TabIndex = 4;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Enabled = false;
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
            this.label1.Location = new System.Drawing.Point(5, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 14);
            this.label1.TabIndex = 23;
            this.label1.Text = "TELEFONE:";
            // 
            // listtelefone
            // 
            this.listtelefone.Enabled = false;
            this.listtelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listtelefone.FormattingEnabled = true;
            this.listtelefone.Location = new System.Drawing.Point(98, 77);
            this.listtelefone.Name = "listtelefone";
            this.listtelefone.Size = new System.Drawing.Size(119, 82);
            this.listtelefone.TabIndex = 25;
            // 
            // btnexcluirtel
            // 
            this.btnexcluirtel.BackgroundImage = global::SDE.Properties.Resources.menos;
            this.btnexcluirtel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnexcluirtel.Enabled = false;
            this.btnexcluirtel.Location = new System.Drawing.Point(54, 99);
            this.btnexcluirtel.Name = "btnexcluirtel";
            this.btnexcluirtel.Size = new System.Drawing.Size(35, 31);
            this.btnexcluirtel.TabIndex = 28;
            this.btnexcluirtel.UseVisualStyleBackColor = true;
            this.btnexcluirtel.Click += new System.EventHandler(this.btnexcluirtel_Click);
            // 
            // btnaddtel
            // 
            this.btnaddtel.BackgroundImage = global::SDE.Properties.Resources.Mais;
            this.btnaddtel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnaddtel.Enabled = false;
            this.btnaddtel.Location = new System.Drawing.Point(54, 62);
            this.btnaddtel.Name = "btnaddtel";
            this.btnaddtel.Size = new System.Drawing.Size(35, 31);
            this.btnaddtel.TabIndex = 3;
            this.btnaddtel.UseVisualStyleBackColor = true;
            this.btnaddtel.Click += new System.EventHandler(this.btnaddtel_Click);
            // 
            // btnlimpartel
            // 
            this.btnlimpartel.BackgroundImage = global::SDE.Properties.Resources.Limpar;
            this.btnlimpartel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlimpartel.Enabled = false;
            this.btnlimpartel.Location = new System.Drawing.Point(54, 135);
            this.btnlimpartel.Name = "btnlimpartel";
            this.btnlimpartel.Size = new System.Drawing.Size(35, 31);
            this.btnlimpartel.TabIndex = 27;
            this.btnlimpartel.UseVisualStyleBackColor = true;
            this.btnlimpartel.Click += new System.EventHandler(this.btnlimpartel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(205, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 75;
            this.label3.Text = "*DATA NASCIMENTO";
            // 
            // txtfuncaofunc
            // 
            this.txtfuncaofunc.Enabled = false;
            this.txtfuncaofunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfuncaofunc.Location = new System.Drawing.Point(82, 156);
            this.txtfuncaofunc.Name = "txtfuncaofunc";
            this.txtfuncaofunc.Size = new System.Drawing.Size(107, 20);
            this.txtfuncaofunc.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label2.Location = new System.Drawing.Point(27, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 14);
            this.label2.TabIndex = 73;
            this.label2.Text = "*SETOR";
            // 
            // txtComplementofunc
            // 
            this.txtComplementofunc.Enabled = false;
            this.txtComplementofunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComplementofunc.Location = new System.Drawing.Point(581, 62);
            this.txtComplementofunc.Name = "txtComplementofunc";
            this.txtComplementofunc.Size = new System.Drawing.Size(85, 20);
            this.txtComplementofunc.TabIndex = 4;
            // 
            // txtnumerofunc
            // 
            this.txtnumerofunc.Enabled = false;
            this.txtnumerofunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerofunc.Location = new System.Drawing.Point(394, 62);
            this.txtnumerofunc.Name = "txtnumerofunc";
            this.txtnumerofunc.Size = new System.Drawing.Size(85, 20);
            this.txtnumerofunc.TabIndex = 3;
            // 
            // lblcep
            // 
            this.lblcep.AutoSize = true;
            this.lblcep.BackColor = System.Drawing.Color.Transparent;
            this.lblcep.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcep.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcep.Location = new System.Drawing.Point(18, 95);
            this.lblcep.Name = "lblcep";
            this.lblcep.Size = new System.Drawing.Size(28, 14);
            this.lblcep.TabIndex = 67;
            this.lblcep.Text = "CEP";
            // 
            // lblnumero
            // 
            this.lblnumero.AutoSize = true;
            this.lblnumero.BackColor = System.Drawing.Color.Transparent;
            this.lblnumero.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumero.Location = new System.Drawing.Point(332, 68);
            this.lblnumero.Name = "lblnumero";
            this.lblnumero.Size = new System.Drawing.Size(61, 15);
            this.lblnumero.TabIndex = 66;
            this.lblnumero.Text = "NUMERO";
            // 
            // txtbairrofunc
            // 
            this.txtbairrofunc.Enabled = false;
            this.txtbairrofunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbairrofunc.Location = new System.Drawing.Point(239, 89);
            this.txtbairrofunc.Name = "txtbairrofunc";
            this.txtbairrofunc.Size = new System.Drawing.Size(100, 20);
            this.txtbairrofunc.TabIndex = 6;
            // 
            // txtruafunc
            // 
            this.txtruafunc.Enabled = false;
            this.txtruafunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtruafunc.Location = new System.Drawing.Point(82, 60);
            this.txtruafunc.Name = "txtruafunc";
            this.txtruafunc.Size = new System.Drawing.Size(227, 20);
            this.txtruafunc.TabIndex = 2;
            // 
            // lblcomplemento
            // 
            this.lblcomplemento.AutoSize = true;
            this.lblcomplemento.BackColor = System.Drawing.Color.Transparent;
            this.lblcomplemento.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomplemento.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcomplemento.Location = new System.Drawing.Point(481, 66);
            this.lblcomplemento.Name = "lblcomplemento";
            this.lblcomplemento.Size = new System.Drawing.Size(94, 14);
            this.lblcomplemento.TabIndex = 62;
            this.lblcomplemento.Text = "COMPLEMENTO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(188, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 14);
            this.label6.TabIndex = 61;
            this.label6.Text = "BAIRRO";
            // 
            // lblrua
            // 
            this.lblrua.AutoSize = true;
            this.lblrua.BackColor = System.Drawing.Color.Transparent;
            this.lblrua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrua.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblrua.Location = new System.Drawing.Point(0, 68);
            this.lblrua.Name = "lblrua";
            this.lblrua.Size = new System.Drawing.Size(76, 14);
            this.lblrua.TabIndex = 60;
            this.lblrua.Text = "LOGADOURO";
            // 
            // lblcnpj
            // 
            this.lblcnpj.AutoSize = true;
            this.lblcnpj.BackColor = System.Drawing.Color.Transparent;
            this.lblcnpj.Font = new System.Drawing.Font("Bell MT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcnpj.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblcnpj.Location = new System.Drawing.Point(467, 36);
            this.lblcnpj.Name = "lblcnpj";
            this.lblcnpj.Size = new System.Drawing.Size(36, 15);
            this.lblcnpj.TabIndex = 59;
            this.lblcnpj.Text = "*CPF";
            // 
            // txtnomefunc
            // 
            this.txtnomefunc.Enabled = false;
            this.txtnomefunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnomefunc.Location = new System.Drawing.Point(82, 34);
            this.txtnomefunc.Name = "txtnomefunc";
            this.txtnomefunc.Size = new System.Drawing.Size(368, 20);
            this.txtnomefunc.TabIndex = 0;
            // 
            // lblnome
            // 
            this.lblnome.AutoSize = true;
            this.lblnome.BackColor = System.Drawing.Color.Transparent;
            this.lblnome.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnome.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblnome.Location = new System.Drawing.Point(9, 36);
            this.lblnome.Name = "lblnome";
            this.lblnome.Size = new System.Drawing.Size(46, 14);
            this.lblnome.TabIndex = 57;
            this.lblnome.Text = "*NOME";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.mskpesquisar);
            this.groupBox3.Controls.Add(this.txtpesquisar);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(231, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(297, 47);
            this.groupBox3.TabIndex = 70;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisar";
            // 
            // mskpesquisar
            // 
            this.mskpesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskpesquisar.Location = new System.Drawing.Point(116, 14);
            this.mskpesquisar.Mask = "000.000.000-00";
            this.mskpesquisar.Name = "mskpesquisar";
            this.mskpesquisar.Size = new System.Drawing.Size(107, 20);
            this.mskpesquisar.TabIndex = 0;
            // 
            // txtpesquisar
            // 
            this.txtpesquisar.BackgroundImage = global::SDE.Properties.Resources.Pesquisar;
            this.txtpesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.txtpesquisar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpesquisar.Location = new System.Drawing.Point(229, 11);
            this.txtpesquisar.Name = "txtpesquisar";
            this.txtpesquisar.Size = new System.Drawing.Size(34, 26);
            this.txtpesquisar.TabIndex = 1;
            this.txtpesquisar.UseVisualStyleBackColor = true;
            this.txtpesquisar.Click += new System.EventHandler(this.txtpesquisar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(74, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "CPF:";
            // 
            // btnalterar
            // 
            this.btnalterar.BackgroundImage = global::SDE.Properties.Resources.alterar;
            this.btnalterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnalterar.Location = new System.Drawing.Point(445, 352);
            this.btnalterar.Name = "btnalterar";
            this.btnalterar.Size = new System.Drawing.Size(49, 49);
            this.btnalterar.TabIndex = 71;
            this.btnalterar.UseVisualStyleBackColor = true;
            this.btnalterar.Click += new System.EventHandler(this.txtalterar_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 605);
            this.Controls.Add(this.btnalterar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dgvfuncionario);
            this.Controls.Add(this.btnnovo);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExlucir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Funcionario";
            this.Load += new System.EventHandler(this.FrmFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfuncionario)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvfuncionario;
        private System.Windows.Forms.Button btnnovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExlucir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox txtcnh;
        private System.Windows.Forms.MaskedTextBox txtnascfunc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtcpffunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txttelefone;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listtelefone;
        private System.Windows.Forms.Button btnexcluirtel;
        private System.Windows.Forms.Button btnaddtel;
        private System.Windows.Forms.Button btnlimpartel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComplementofunc;
        private System.Windows.Forms.TextBox txtnumerofunc;
        private System.Windows.Forms.Label lblcep;
        private System.Windows.Forms.Label lblnumero;
        private System.Windows.Forms.TextBox txtbairrofunc;
        private System.Windows.Forms.TextBox txtruafunc;
        private System.Windows.Forms.Label lblcomplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblrua;
        private System.Windows.Forms.Label lblcnpj;
        private System.Windows.Forms.TextBox txtnomefunc;
        private System.Windows.Forms.Label lblnome;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MaskedTextBox mskpesquisar;
        private System.Windows.Forms.Button txtpesquisar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnalterar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtfuncaofunc;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtcargo;
        private System.Windows.Forms.MaskedTextBox txtcepfunc;
    }
}