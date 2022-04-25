using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SDE
{
    public partial class FrmConsultaFunc : Form
    {
        ClassFuncionario Func = new ClassFuncionario();
        string codigoId;
        public FrmConsultaFunc()
        {
            InitializeComponent();
            dataGridView1.DataSource = Func.preencherDataGrid();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 60;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmConsultaFunc_Load(object sender, EventArgs e)
        {
            this.dataGridView1.Columns.Add("Name", "Text");

            // Put all these strings into rows.
            string[] input = new string[] { "Alternating", "Row", "Colors", "Are", "Neat" };
            foreach (string val in input)
            {
                this.dataGridView1.Rows.Add(new string[] { val });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            codigoId = row.Cells["codFuncionario"].Value.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            FrmFuncionario formDestino = new FrmFuncionario();
            formDestino.Propriedade = codigoId;
            formDestino.Show();
        }

    

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.Text == "CPF")
            {
                txtpsqcnpj.Visible = true;
                txtpsqnome.Visible = false;
                
            }

            if (cmb.Text == "NOME")
            {
                txtpsqcnpj.Visible = false;
                txtpsqnome.Visible = true;

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cmb.Text == "CPF")
            {
                dataGridView1.DataSource = Func.pesquisacpf(txtpsqcnpj.Text);
            }


           
        }

        private void txtpsqnome_TextChanged(object sender, EventArgs e)
        {

            dataGridView1.DataSource = Func.pesquisaaproximada(txtpsqnome.Text);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmFuncionario formDestino = new FrmFuncionario();
            formDestino.Propriedade = codigoId;
            formDestino.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmFuncionario formDestino = new FrmFuncionario();
            formDestino.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource = Func.preencherDataGrid();
           txtpsqnome.Clear();
           txtpsqcnpj.Clear();
           txtpsqnome.Enabled = true;
        }
    }
}
