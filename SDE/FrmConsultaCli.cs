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
    public partial class FrmConsultaCli : Form
    {
        ClassCliente cli = new ClassCliente();
        string codigoId;
        public FrmConsultaCli()
        {
            
            InitializeComponent();
            txtpsqcnpj.Visible = false;
            txtpsqnome.Visible = true;
            dataGridView1.DataSource = cli.preencherDataGrid();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Width = 180;
            dataGridView1.Columns[2].Width = 120;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.Text == "CNPJ")
            {
                txtpsqcnpj.Visible = true;
                txtpsqnome.Visible = false;
                dataGridView1.DataSource = cli.pesquisaExatacnpj(txtpsqcnpj.Text);
            }

            if (cmb.Text == "NOME")
            {
                txtpsqcnpj.Visible = false;
                txtpsqnome.Visible = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmb.Text == "CNPJ")
            {
                 dataGridView1.DataSource = cli.pesquisaExatacnpj(txtpsqcnpj.Text);
            }

            if (cmb.Text == "NOME")
            {
               
            }
            
            
            
        }

        private void FrmConsultaCli_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            int linhaAtual = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
           codigoId = row.Cells["codCliente"].Value.ToString();
            
        }

        private void txtalterar_Click(object sender, EventArgs e)
        {

            FrmCliente formDestino = new FrmCliente();
            formDestino.Propriedade = codigoId;
            formDestino.Show();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtpsqcnpj.Visible = false;
            txtpsqnome.Visible = true;
            txtpsqnome.Clear();
            txtpsqcnpj.Clear();
            dataGridView1.DataSource = cli.preencherDataGrid();

        }

        private void txtpsqnome_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cli.pesquisaaproximada(txtpsqnome.Text);
        }

        private void btnExlucir_Click(object sender, EventArgs e)
        {
            FrmCliente formDestino = new FrmCliente();
            formDestino.Propriedade = codigoId;
            formDestino.Show();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            FrmCliente formDestino = new FrmCliente();
            formDestino.Show();
        }
    }
}
