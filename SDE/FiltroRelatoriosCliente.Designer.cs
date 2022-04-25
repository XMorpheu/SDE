namespace SDE
{
    partial class FiltroRelatoriosCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FiltroRelatoriosCliente));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPornomeCli = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.cbmPesquisa = new System.Windows.Forms.ComboBox();
            this.grupNome = new System.Windows.Forms.GroupBox();
            this.groupGeral = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.grupNome.SuspendLayout();
            this.groupGeral.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(101, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Relatório :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(40, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Relatório Por Nome";
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
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(35, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(104, 20);
            this.txtNome.TabIndex = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.BeginPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_BeginPrint);
            this.printDocument1.EndPrint += new System.Drawing.Printing.PrintEventHandler(this.printDocument1_EndPrint);
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // cbmPesquisa
            // 
            this.cbmPesquisa.FormattingEnabled = true;
            this.cbmPesquisa.Items.AddRange(new object[] {
            "Nome",
            "Geral"});
            this.cbmPesquisa.Location = new System.Drawing.Point(162, 23);
            this.cbmPesquisa.Name = "cbmPesquisa";
            this.cbmPesquisa.Size = new System.Drawing.Size(121, 21);
            this.cbmPesquisa.TabIndex = 11;
            this.cbmPesquisa.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // grupNome
            // 
            this.grupNome.BackColor = System.Drawing.Color.Transparent;
            this.grupNome.Controls.Add(this.btnPornomeCli);
            this.grupNome.Controls.Add(this.txtNome);
            this.grupNome.Controls.Add(this.label5);
            this.grupNome.Location = new System.Drawing.Point(209, 60);
            this.grupNome.Name = "grupNome";
            this.grupNome.Size = new System.Drawing.Size(165, 95);
            this.grupNome.TabIndex = 14;
            this.grupNome.TabStop = false;
            this.grupNome.Text = "Nome";
            this.grupNome.Enter += new System.EventHandler(this.grupNome_Enter);
            // 
            // groupGeral
            // 
            this.groupGeral.BackColor = System.Drawing.Color.Transparent;
            this.groupGeral.Controls.Add(this.label6);
            this.groupGeral.Controls.Add(this.button2);
            this.groupGeral.Location = new System.Drawing.Point(23, 60);
            this.groupGeral.Name = "groupGeral";
            this.groupGeral.Size = new System.Drawing.Size(152, 95);
            this.groupGeral.TabIndex = 21;
            this.groupGeral.TabStop = false;
            this.groupGeral.Text = "Geral";
            this.groupGeral.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(38, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Relatório Geral";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(53, 52);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "OK";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // FiltroRelatoriosCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SDE.Properties.Resources.Fundo_Secundario_fw;
            this.ClientSize = new System.Drawing.Size(407, 239);
            this.Controls.Add(this.groupGeral);
            this.Controls.Add(this.cbmPesquisa);
            this.Controls.Add(this.grupNome);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FiltroRelatoriosCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.FiltroRelatoriosCliente_Load);
            this.grupNome.ResumeLayout(false);
            this.grupNome.PerformLayout();
            this.groupGeral.ResumeLayout(false);
            this.groupGeral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPornomeCli;
        private System.Windows.Forms.TextBox txtNome;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.ComboBox cbmPesquisa;
        private System.Windows.Forms.GroupBox grupNome;
        private System.Windows.Forms.GroupBox groupGeral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
    }
}