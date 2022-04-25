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
    public partial class FrmCargo : Form
    {
        conexao c = new conexao();
        ClassCargo cargo = new ClassCargo();
        int alterar;
        int cod;
        public FrmCargo()
        {
            
            InitializeComponent();
            dataGridView1.DataSource = cargo.preencherDataGrid();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.Columns[0].Visible = false;
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cargo.pesquisaAproximadaNome(txtpesquisar.Text);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int consulta = cargo.ConsultaCargo(Convert.ToString(txtCargo.Text));
            if (alterar > 0)
            {
                MessageBox.Show(cargo.alterareCargo(txtCargo.Text, cod));
                dataGridView1.DataSource = cargo.preencherDataGrid();
                txtCargo.Clear();
                txtCargo.Enabled = false;
                txtpesquisar.Enabled = false;
                btnSalvar.Enabled = false;
                btnExlucir.Enabled = false;
                btnalterar.Enabled = false;



            }

            else
            {
                if (consulta == 0)
                {
                    MessageBox.Show(cargo.cadastrarCargo(txtCargo.Text));
                    dataGridView1.DataSource = cargo.preencherDataGrid();
                    btnSalvar.Enabled = false;
                    btnExlucir.Enabled = false;
                    btnalterar.Enabled = false;
                    txtCargo.Clear();
                    txtCargo.Enabled = false;


                }
                else
                {
                    String menssagem = "Cargo já está cadastrado";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void FrmCargo_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;
            txtCargo.Enabled = false;
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtpesquisar.Enabled = false;
            txtCargo.Enabled = true;
            btnSalvar.Enabled = true;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtCargo.Clear();

            btnSalvar.Enabled = false;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;

            txtCargo.Enabled = true;
            txtpesquisar.Enabled = true;
            txtCargo.Enabled = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnExlucir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o estado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(cargo.excluirCargo(cod));
                dataGridView1.DataSource = cargo.preencherDataGrid();
                txtCargo.Clear();
                txtCargo.Enabled = false;
                btnExlucir.Enabled = false;
                btnalterar.Enabled = false;
                btnSalvar.Enabled = false;


            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar o Cargo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                alterar = 1;
                txtCargo.Enabled = true;
                btnSalvar.Enabled = true;
                btnnovo.Enabled = true;

            }
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            alterar = 0;
            int linhaAtual = dataGridView1.CurrentCell.RowIndex;
            string codFuncionario = dataGridView1[0, linhaAtual].Value.ToString();
            cod = Convert.ToInt16(codFuncionario);
            txtCargo.Text = dataGridView1[1, linhaAtual].Value.ToString();

            btnSalvar.Enabled = false;
            btnExlucir.Enabled = true;
            btnalterar.Enabled = true;
            txtpesquisar.Enabled = false;
        }
    }
}
