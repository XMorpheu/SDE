namespace SDE
{
    partial class FiltroRelatorioEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroRelatorioEntrega));
            this.grupGeral = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grupNome = new System.Windows.Forms.GroupBox();
            this.btnPornomeCli = new System.Windows.Forms.Button();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grupData = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPordataCli = new System.Windows.Forms.Button();
            this.cbmPesquisa = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grupGeral.SuspendLayout();
            this.grupNome.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grupData.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupGeral
            // 
            this.grupGeral.BackColor = System.Drawing.Color.Transparent;
            this.grupGeral.Controls.Add(this.label1);
            this.grupGeral.Controls.Add(this.button1);
            this.grupGeral.Location = new System.Drawing.Point(129, 64);
            this.grupGeral.Name = "grupGeral";
            this.grupGeral.Size = new System.Drawing.Size(152, 88);
            this.grupGeral.TabIndex = 16;
            this.grupGeral.TabStop = false;
            this.grupGeral.Text = "Geral";
            this.grupGeral.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Relatório Geral";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // grupNome
            // 
            this.grupNome.BackColor = System.Drawing.Color.Transparent;
            this.grupNome.Controls.Add(this.btnPornomeCli);
            this.grupNome.Controls.Add(this.txt2);
            this.grupNome.Controls.Add(this.label5);
            this.grupNome.Location = new System.Drawing.Point(240, 64);
            this.grupNome.Name = "grupNome";
            this.grupNome.Size = new System.Drawing.Size(165, 95);
            this.grupNome.TabIndex = 17;
            this.grupNome.TabStop = false;
            this.grupNome.Text = "Nome";
            this.grupNome.Visible = false;
            // 
            // btnPornomeCli
            // 
            this.btnPornomeCli.Location = new System.Drawing.Point(64, 63);
            this.btnPornomeCli.Name = "btnPornomeCli";
            this.btnPornomeCli.Size = new System.Drawing.Size(50, 23);
            this.btnPornomeCli.TabIndex = 9;
            this.btnPornomeCli.Text = "OK";
            this.btnPornomeCli.UseVisualStyleBackColor = true;
            this.btnPornomeCli.Click += new System.EventHandler(this.btnPornomeCli_Click);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(35, 37);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(104, 20);
            this.txt2.TabIndex = 10;
            this.txt2.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Relatório Por Motorista";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 95);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nome";
            this.groupBox1.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(64, 63);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(35, 37);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(104, 20);
            this.txt1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(40, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Relatório Por Cliente";
            // 
            // grupData
            // 
            this.grupData.BackColor = System.Drawing.Color.Transparent;
            this.grupData.Controls.Add(this.groupBox2);
            this.grupData.Controls.Add(this.dateTimePicker1);
            this.grupData.Controls.Add(this.label4);
            this.grupData.Controls.Add(this.btnPordataCli);
            this.grupData.Location = new System.Drawing.Point(113, 80);
            this.grupData.Name = "grupData";
            this.grupData.Size = new System.Drawing.Size(188, 127);
            this.grupData.TabIndex = 19;
            this.grupData.TabStop = false;
            this.grupData.Text = "Data";
            this.grupData.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Location = new System.Drawing.Point(233, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 85);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Geral";
            this.groupBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(38, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Relatório Geral";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(53, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 0;
            this.button3.Text = "OK";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(44, 54);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(47, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Relatório Por Data";
            // 
            // btnPordataCli
            // 
            this.btnPordataCli.Location = new System.Drawing.Point(71, 88);
            this.btnPordataCli.Name = "btnPordataCli";
            this.btnPordataCli.Size = new System.Drawing.Size(50, 23);
            this.btnPordataCli.TabIndex = 3;
            this.btnPordataCli.Text = "OK";
            this.btnPordataCli.UseVisualStyleBackColor = true;
            this.btnPordataCli.Click += new System.EventHandler(this.btnPordataCli_Click);
            // 
            // cbmPesquisa
            // 
            this.cbmPesquisa.FormattingEnabled = true;
            this.cbmPesquisa.Items.AddRange(new object[] {
            "Nome Motorista",
            "Nome Cliente",
            "Data",
            "Geral"});
            this.cbmPesquisa.Location = new System.Drawing.Point(180, 37);
            this.cbmPesquisa.Name = "cbmPesquisa";
            this.cbmPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbmPesquisa.TabIndex = 21;
            this.cbmPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbmPesquisa_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(119, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Relatório :";
            // 
            // FiltroRelatorioEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.ClientSize = new System.Drawing.Size(404, 239);
            this.Controls.Add(this.grupGeral);
            this.Controls.Add(this.cbmPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupNome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.grupData);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiltroRelatorioEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro Relatorio Entrega";
            this.grupGeral.ResumeLayout(false);
            this.grupGeral.PerformLayout();
            this.grupNome.ResumeLayout(false);
            this.grupNome.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grupData.ResumeLayout(false);
            this.grupData.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupGeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox grupNome;
        private System.Windows.Forms.Button btnPornomeCli;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grupData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnPordataCli;
        private System.Windows.Forms.ComboBox cbmPesquisa;
        private System.Windows.Forms.Label label6;
    }
}