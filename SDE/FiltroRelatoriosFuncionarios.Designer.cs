namespace SDE
{
    partial class FiltroRelatoriosFuncionarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroRelatoriosFuncionarios));
            this.grupGeral = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.grupNome = new System.Windows.Forms.GroupBox();
            this.btnPornomeCli = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmPesquisa = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grupData = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPordataCli = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.grupGeral.SuspendLayout();
            this.grupNome.SuspendLayout();
            this.grupData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupGeral
            // 
            this.grupGeral.BackColor = System.Drawing.Color.Transparent;
            this.grupGeral.Controls.Add(this.label1);
            this.grupGeral.Controls.Add(this.button1);
            this.grupGeral.Location = new System.Drawing.Point(16, 82);
            this.grupGeral.Name = "grupGeral";
            this.grupGeral.Size = new System.Drawing.Size(152, 95);
            this.grupGeral.TabIndex = 20;
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
            // grupNome
            // 
            this.grupNome.BackColor = System.Drawing.Color.Transparent;
            this.grupNome.Controls.Add(this.btnPornomeCli);
            this.grupNome.Controls.Add(this.txtNome);
            this.grupNome.Controls.Add(this.label5);
            this.grupNome.Location = new System.Drawing.Point(243, 77);
            this.grupNome.Name = "grupNome";
            this.grupNome.Size = new System.Drawing.Size(152, 100);
            this.grupNome.TabIndex = 19;
            this.grupNome.TabStop = false;
            this.grupNome.Text = "Nome";
            this.grupNome.Visible = false;
            // 
            // btnPornomeCli
            // 
            this.btnPornomeCli.Location = new System.Drawing.Point(52, 67);
            this.btnPornomeCli.Name = "btnPornomeCli";
            this.btnPornomeCli.Size = new System.Drawing.Size(50, 23);
            this.btnPornomeCli.TabIndex = 9;
            this.btnPornomeCli.Text = "OK";
            this.btnPornomeCli.UseVisualStyleBackColor = true;
            this.btnPornomeCli.Click += new System.EventHandler(this.btnPornomeCli_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 41);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Relatório Por Nome";
            // 
            // cbmPesquisa
            // 
            this.cbmPesquisa.FormattingEnabled = true;
            this.cbmPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Data",
            "Geral"});
            this.cbmPesquisa.Location = new System.Drawing.Point(162, 17);
            this.cbmPesquisa.Name = "cbmPesquisa";
            this.cbmPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbmPesquisa.TabIndex = 17;
            this.cbmPesquisa.SelectedIndexChanged += new System.EventHandler(this.cbmPesquisa_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(101, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Relatório :";
            // 
            // grupData
            // 
            this.grupData.BackColor = System.Drawing.Color.Transparent;
            this.grupData.Controls.Add(this.dateTimePicker1);
            this.grupData.Controls.Add(this.label2);
            this.grupData.Controls.Add(this.btnPordataCli);
            this.grupData.Location = new System.Drawing.Point(125, 74);
            this.grupData.Name = "grupData";
            this.grupData.Size = new System.Drawing.Size(168, 126);
            this.grupData.TabIndex = 18;
            this.grupData.TabStop = false;
            this.grupData.Text = "Data";
            this.grupData.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(49, 55);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.Value = new System.DateTime(2014, 5, 17, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(46, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Relatório Por Data";
            // 
            // btnPordataCli
            // 
            this.btnPordataCli.Location = new System.Drawing.Point(62, 81);
            this.btnPordataCli.Name = "btnPordataCli";
            this.btnPordataCli.Size = new System.Drawing.Size(50, 23);
            this.btnPordataCli.TabIndex = 3;
            this.btnPordataCli.Text = "OK";
            this.btnPordataCli.UseVisualStyleBackColor = true;
            this.btnPordataCli.Click += new System.EventHandler(this.btnPordataCli_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FiltroRelatoriosFuncionarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.ClientSize = new System.Drawing.Size(404, 239);
            this.Controls.Add(this.grupData);
            this.Controls.Add(this.grupNome);
            this.Controls.Add(this.grupGeral);
            this.Controls.Add(this.cbmPesquisa);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiltroRelatoriosFuncionarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.FiltroRelatoriosFuncionarios_Load);
            this.grupGeral.ResumeLayout(false);
            this.grupGeral.PerformLayout();
            this.grupNome.ResumeLayout(false);
            this.grupNome.PerformLayout();
            this.grupData.ResumeLayout(false);
            this.grupData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupGeral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grupNome;
        private System.Windows.Forms.Button btnPornomeCli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmPesquisa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grupData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPordataCli;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}