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
    public partial class FrmVeiculo : Form
    {
        conexao c = new conexao();
        ClassVeiculo vei = new ClassVeiculo();
        int cod;
        int alterar = 0;

        public FrmVeiculo()
        {
            InitializeComponent();
            dgvVeiculo.DataSource = vei.preencherDataGrid();
            dgvVeiculo.Columns[0].Visible = false;            
            dgvVeiculo.Columns[1].Width = 180;
             this.dgvVeiculo.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                 this.dgvVeiculo.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            preencherCor();
            preencherMarca();
        }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            alterar = 0;
            txtchassi.Enabled = true;
            txtcor.Enabled = true;
            txtmarca.Enabled = true;
            txtmodelo.Enabled = true;
            txtpesquisaplaca.Enabled = true;
            txtplaca.Enabled = true;
            txtrodizio.Enabled = false;
            txtpesquisaplaca.Enabled = false;
            button1.Enabled = false;
            btnSalvar.Enabled = true;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;

            txtchassi.Clear();

            txtmarca.Items.Add("");
            txtmodelo.Items.Add("");
            txtpesquisaplaca.Clear();
            txtplaca.Clear();
            txtrodizio.Clear();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int consulta = vei.Consultarplaca(Convert.ToString(txtplaca.Text));

            if (txtmarca.Text != string.Empty && txtcor.Text != string.Empty
                && txtchassi.Text != string.Empty && txtmodelo.Text != string.Empty
                && txtplaca.Text != string.Empty && txtrodizio.Text != string.Empty)
            {
                if (alterar > 0)
                {

                    String menssagem = "Veículo cadastrado com sucesso.";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);

                    MessageBox.Show(vei.alterarveiculo(txtcor.Text, txtmarca.Text, txtmodelo.Text, txtplaca.Text, txtrodizio.Text, txtchassi.Text, cod));
                    txtchassi.Clear();

                    txtmarca.Items.Add("");
                    txtmodelo.Items.Add("");
                    txtpesquisaplaca.Clear();
                    txtplaca.Clear();
                    txtrodizio.Clear();


                    txtchassi.Enabled = false;
                    txtcor.Enabled = false;
                    txtmarca.Enabled = false;
                    txtmodelo.Enabled = false;
                    txtpesquisaplaca.Enabled = true;
                    txtplaca.Enabled = false;
                    txtrodizio.Enabled = false;
                    button1.Enabled = true;
                }

                else
                {

                    if (consulta == 0)
                    {
                        MessageBox.Show(vei.cadastrarVeiculo(txtcor.Text, txtmarca.Text, txtmodelo.Text, txtplaca.Text, txtrodizio.Text, txtchassi.Text));

                        String menssagem = "Erro No cadastro";
                        String titulo = "SDE";
                        MessageBox.Show(menssagem, titulo,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                        txtchassi.Clear();

                        txtmarca.Items.Add("");
                        txtmodelo.Items.Add("");
                        txtpesquisaplaca.Clear();
                        txtplaca.Clear();
                        txtrodizio.Clear();


                        txtchassi.Enabled = false;
                        txtcor.Enabled = false;
                        txtmarca.Enabled = false;
                        txtmodelo.Enabled = false;
                        txtpesquisaplaca.Enabled = true;
                        txtplaca.Enabled = false;
                        txtrodizio.Enabled = false;
                        button1.Enabled = true;
                    }
                    else
                    {

                        String menssagem = "Esta Placa já esta Cadastrada";
                        String titulo = "SDE";
                        MessageBox.Show(menssagem, titulo,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                    }
                }

                dgvVeiculo.DataSource = vei.preencherDataGrid();
            }
            else
            {

                String menssagem = "Os campos com (*) são de preenchemento obrigatório";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtchassi.Clear();

            txtmarca.Items.Add("");
            txtmodelo.Items.Add(""); ;
            txtpesquisaplaca.Clear();
            txtplaca.Clear();
            txtrodizio.Clear();


            txtchassi.Enabled = false;
            txtcor.Enabled = false;
            txtmarca.Enabled = false;
            txtmodelo.Enabled = false;
            txtpesquisaplaca.Enabled = true;
            txtplaca.Enabled = false;
            txtrodizio.Enabled = false;
            button1.Enabled = true;
            btnSalvar.Enabled = false;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvVeiculo.DataSource = vei.pesquisaExataPlaca(txtpesquisaplaca.Text);
        }

        private void dgvVeiculo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvVeiculo.CurrentCell.RowIndex;
            dgvVeiculo.DataSource = vei.preencherDataGrid();
            
                DataGridViewRow row = this.dgvVeiculo.Rows[e.RowIndex];
                string codigoId = row.Cells["codVeiculo"].Value.ToString();
                cod = Convert.ToInt16(codigoId);

                txtmodelo.Text = dgvVeiculo[1, linhaAtual].Value.ToString();
                txtplaca.Text = dgvVeiculo[2, linhaAtual].Value.ToString();
                txtmarca.Text = dgvVeiculo[3, linhaAtual].Value.ToString();
                txtcor.Text = dgvVeiculo[4, linhaAtual].Value.ToString();
                txtrodizio.Text = dgvVeiculo[5, linhaAtual].Value.ToString();
                txtchassi.Text = dgvVeiculo[6, linhaAtual].Value.ToString();
                btnalterar.Enabled = true;
                btnSalvar.Enabled = false;
                btnExlucir.Enabled = true;
                txtchassi.Enabled = false;
                txtcor.Enabled = false;
                txtmarca.Enabled = false;
                txtmodelo.Enabled = false;
                txtpesquisaplaca.Enabled = true;
                txtplaca.Enabled = false;
                txtrodizio.Enabled = false;
                

                dgvVeiculo.DataSource = vei.preencherDataGrid();


            

        }

        private void btnExlucir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente Excluir esse veiculo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(vei.excluirVeiculo(cod));
                txtchassi.Clear();

                txtmarca.Items.Add("");
                txtmodelo.Items.Add("");
                txtpesquisaplaca.Clear();
                txtplaca.Clear();
                txtrodizio.Clear();


                txtchassi.Enabled = false;
                txtcor.Enabled = false;
                txtmarca.Enabled = false;
                txtmodelo.Enabled = false;
                txtpesquisaplaca.Enabled = true;
                txtplaca.Enabled = false;
                txtrodizio.Enabled = false;
                button1.Enabled = true;
                btnSalvar.Enabled = false;
                btnExlucir.Enabled = false;
                btnalterar.Enabled = false;

                dgvVeiculo.DataSource = vei.preencherDataGrid();
            }
        }

        private void btnalterar_Click(object sender, EventArgs e)
        {
           
     
 
            if (MessageBox.Show("Deseja realmente alterar o veiculo?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                alterar = 1;
                txtchassi.Enabled = true;
                txtcor.Enabled = true;
                txtmarca.Enabled = true;
                txtmodelo.Enabled = true;
                txtpesquisaplaca.Enabled = true;
                txtplaca.Enabled = true;
                txtrodizio.Enabled = false;
                txtpesquisaplaca.Enabled = false;
                button1.Enabled = false;
                btnExlucir.Enabled = true;
                btnSalvar.Enabled = true;
                
            }
        }

        private void txtplaca_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmVeiculo_Load(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            btnExlucir.Enabled = false;
            btnalterar.Enabled = false;
        }

        public void preencherCor()
        {
            String[] lista = vei.carregarCor();

            for (int i = 0; i < lista.Length; i++)
            {
                txtcor.Items.Add(lista[i]);

            }
        }

        public void preencherMarca()
        {
            String[] lista = vei.carregarMarca();

            for (int i = 0; i < lista.Length; i++)
            {
                txtmarca.Items.Add(lista[i]);

            }
        }

        private void txtrodizio_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            String a = txtplaca.Text;
            
            a = a.Substring(7, 1);

            if (a == "1"|| a=="0" )
            {
                txtrodizio.Text = "Segunda";
            }

            if (a == "2" || a=="3")
            {
                txtrodizio.Text = "Terça";
            }

            if (a == "4" || a=="5")
            {
                txtrodizio.Text = "Quarta";
            }
            if (a == "6" || a=="7" )
            {
                txtrodizio.Text = "Quinta";
            }
            if (a == "8" || a=="9")
            {
                txtrodizio.Text = "Sexta";
            }
        }
    }
}
