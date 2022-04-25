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
    public partial class FrmEstado : Form
    {
        
            conexao c = new conexao();
            ClassEstado est = new ClassEstado();
            int alterar;
            int cod;
        
        
        
        
        public FrmEstado()
        {
            InitializeComponent();
            dataGridView1.DataSource = est.preencherDataGrid();
            dataGridView1.Columns[0].Visible = false;
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor =   Color.White;
        }

      

        private void FrmEstado_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;
            txtestado.Enabled = false;

        }
       
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int consulta = est.ConsultaEstado(Convert.ToString(txtestado.Text));
            if (alterar > 0)
            {
                MessageBox.Show(est.alterareEstado(txtestado.Text, cod));
                dataGridView1.DataSource = est.preencherDataGrid();
                txtestado.Clear();
                txtestado.Enabled = false;
                txtpesquisar.Enabled = false;
                btnSalvar.Enabled = false;
                btnExlucir.Enabled =false;
                btnalterar.Enabled = false;



            }

            else
            {
                if (consulta == 0)
                {
                    MessageBox.Show(est.cadastrarEstado(txtestado.Text));
                    btnSalvar.Enabled = false;
                    btnExlucir.Enabled = false;
                    btnalterar.Enabled = false;
                    txtestado.Clear();
                    txtestado.Enabled = false;

                    
                }
                else 
                {
                    String menssagem = "Estado já está cadastrado";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = est.pesquisaAproximadaNome(txtpesquisar.Text);
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtpesquisar.Enabled = false;
            txtestado.Enabled = true;
            btnSalvar.Enabled = true;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtestado.Clear();

            btnSalvar.Enabled = false;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;

            txtestado.Enabled = true;
            txtpesquisar.Enabled = true;
            txtestado.Enabled = false;
            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            alterar = 0;
            int linhaAtual = dataGridView1.CurrentCell.RowIndex;
            string codFuncionario = dataGridView1[0, linhaAtual].Value.ToString();
            cod = Convert.ToInt16(codFuncionario);
            txtestado.Text = dataGridView1[1, linhaAtual].Value.ToString();

            btnSalvar.Enabled = false;
            btnExlucir.Enabled = true;
            btnalterar.Enabled = true;
            txtpesquisar.Enabled = false;
        }

        private void btnExlucir_Click(object sender, EventArgs e)
        {
             if (MessageBox.Show("Deseja realmente excluir o estado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(est.excluirEstado(cod));
                dataGridView1.DataSource = est.preencherDataGrid();
                txtestado.Clear();
                txtestado.Enabled = false;
                btnExlucir.Enabled = false;
                btnalterar.Enabled = false;
                btnSalvar.Enabled = false;

              
            }
             }

        private void btnalterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar o estado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                alterar = 1;
                txtestado.Enabled = true;
                btnSalvar.Enabled = true;
                btnnovo.Enabled = true;

            }
        }

        private void txtpesquisar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = est.pesquisaAproximadaNome(txtpesquisar.Text);

        }




        } 
    }

