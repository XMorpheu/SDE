using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SDE
{
    public partial class FrmFuncionario : Form
    {

        conexao c = new conexao();
        ClassFuncionario Func = new ClassFuncionario();
        int cod =0;
        string codCli,pesEstado;
        int est;
        int alterar = 0;
        string consul;

        public FrmFuncionario()
        {
            InitializeComponent();
            carregarCargo();
            dgvfuncionario.DataSource = Func.preencherDataGrid();
            preencherCboEstado();
            dgvfuncionario.Columns[0].Visible = false;
            dgvfuncionario.Columns[1].Width = 180;
            this.dgvfuncionario.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dgvfuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            txtcnh.Items.Add("A");
            txtcnh.Items.Add("B");
            txtcnh.Items.Add("C");
            txtcnh.Items.Add("D");
            txtcnh.Items.Add("E");
        }

        public FrmFuncionario(string valor)
                {
                    InitializeComponent();
                    consul = valor;
               }

        
           public string Propriedade { get; set; }

        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtcnh.Enabled = true;
            txtbairrofunc.Enabled = true;
            txtcargo.Enabled = true;
            txtcepfunc.Enabled = true;
            txtComplementofunc.Enabled = true;
            txtcpffunc.Enabled = true;
            txtfuncaofunc.Enabled = true;
            txtnascfunc.Enabled = true;
            txtnomefunc.Enabled = true;
            txtnumerofunc.Enabled = true;
            txtruafunc.Enabled = true;
            btnaddtel.Enabled = true;
            btnexcluirtel.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            btnlimpartel.Enabled = true;
            listtelefone.Enabled = true;
            mskpesquisar.Enabled = false;
            txtpesquisar.Enabled = false;
            btnalterar.Enabled = false;
            btnExlucir.Enabled = false;
            btnSalvar.Enabled = true;
            dgvfuncionario.Enabled = false;
            alterar = 0;


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            int consulta = Func.ConsultarCpf(Convert.ToString(txtcpffunc.Text));
            String val = txtcpffunc.Text;
            
            

            if (txtnomefunc.Text != string.Empty && txtfuncaofunc.Text != string.Empty
                && txtcargo.Text != string.Empty && txtnascfunc.Text != string.Empty)
            {


                if (validacao.CPF(val))
                {
                    String nome = txtnomefunc.Text;
                    if (validacao.ValidaNome(nome))
                    {
                        String[] numTelCli = new String[listtelefone.Items.Count];

                        for (int i = 0; i < listtelefone.Items.Count; i++)
                        {
                            numTelCli[i] = listtelefone.Items[i].ToString();

                        }



                        if (alterar > 0)
                        {
                            MessageBox.Show(Func.alterarFuncionrio(txtnomefunc.Text, txtcnh.Text, txtnascfunc.Text, txtruafunc.Text, txtbairrofunc.Text, txtcepfunc.Text, txtnumerofunc.Text, txtComplementofunc.Text, txtfuncaofunc.Text, txtcpffunc.Text, txtcargo.Text,est,
                         listtelefone.Items.Count, numTelCli, cod));

                            txtbairrofunc.Clear();
                            txtcargo.Text = "";
                            txtcepfunc.Clear();
                            txtComplementofunc.Clear();
                            txtcpffunc.Clear();
                            txtfuncaofunc.Clear();
                            txtnascfunc.Clear();
                            txtnomefunc.Clear();
                            txtnumerofunc.Clear();
                            txtruafunc.Clear();
                            listtelefone.Items.Clear();

                            txtcnh.Enabled = false;
                            txtbairrofunc.Enabled = false;
                            txtcargo.Enabled = false;
                            txtcepfunc.Enabled = false;
                            txtComplementofunc.Enabled = false;
                            txtcpffunc.Enabled = false;
                            txtfuncaofunc.Enabled = false;
                            txtnascfunc.Enabled = false;
                            txtnomefunc.Enabled = false;
                            txtnumerofunc.Enabled = false;
                            txtruafunc.Enabled = false;
                            btnaddtel.Enabled = false;
                            btnexcluirtel.Enabled = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            btnlimpartel.Enabled = false;
                            listtelefone.Enabled = false;
                            mskpesquisar.Enabled = true;
                            txtpesquisar.Enabled = true;
                            btnalterar.Enabled = false;
                            btnExlucir.Enabled = false;
                            btnSalvar.Enabled = false;
                            dgvfuncionario.Enabled = true;

                        }

                        else
                        {
                            if (alterar == 0)
                            {
                                MessageBox.Show(Func.cadastrarFuncionario(txtnomefunc.Text, txtcnh.Text, txtnascfunc.Text, txtruafunc.Text, txtbairrofunc.Text, txtcepfunc.Text, txtnumerofunc.Text, txtComplementofunc.Text, txtfuncaofunc.Text, txtcpffunc.Text, txtcargo.Text,est,
                                 listtelefone.Items.Count, numTelCli));
                                txtbairrofunc.Clear();
                                txtcargo.Text = "";
                                txtcepfunc.Clear();
                                txtComplementofunc.Clear();
                                txtcpffunc.Clear();
                                txtfuncaofunc.Clear();
                                txtnascfunc.Clear();
                                txtnomefunc.Clear();
                                txtnumerofunc.Clear();
                                txtruafunc.Clear();
                                listtelefone.Items.Clear();

                                txtcnh.Enabled = false;
                                txtbairrofunc.Enabled = false;
                                txtcargo.Enabled = false;
                                txtcepfunc.Enabled = false;
                                txtComplementofunc.Enabled = false;
                                txtcpffunc.Enabled = false;
                                txtfuncaofunc.Enabled = false;
                                txtnascfunc.Enabled = false;
                                txtnomefunc.Enabled = false;
                                txtnumerofunc.Enabled = false;
                                txtruafunc.Enabled = false;
                                btnaddtel.Enabled = false;
                                btnexcluirtel.Enabled = false;
                                radioButton1.Enabled = false;
                                radioButton2.Enabled = false;
                                btnlimpartel.Enabled = false;
                                listtelefone.Enabled = false;
                                mskpesquisar.Enabled = true;
                                txtpesquisar.Enabled = true;
                                btnalterar.Enabled = false;
                                btnExlucir.Enabled = false;
                                btnSalvar.Enabled = true;
                                dgvfuncionario.Enabled = true;
                            }
                            else
                            {
                                String menssagem = "CPF Já Cadastrado";
                                String titulo = "SDE";
                                MessageBox.Show(menssagem, titulo,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);                              
                            }
                        }
                        //carregar datagrid 
                        dgvfuncionario.DataSource = Func.preencherDataGrid();






                    }

                    else
                    {
                        String menssagem = "Nome Invalido";
                        String titulo = "SDE";
                        MessageBox.Show(menssagem, titulo,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                        txtnomefunc.BackColor = Color.LightSteelBlue;

                    }


                }

                else
                {
                    String menssagem = "CPF Invalido";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    txtcpffunc.BackColor = Color.LightSteelBlue;
                }


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
            txtbairrofunc.Clear();
          
            txtcepfunc.Clear();
            txtComplementofunc.Clear();
            txtcpffunc.Clear();
            txtfuncaofunc.Clear();
            txtnascfunc.Clear();
            txtnomefunc.Clear();
            txtnumerofunc.Clear();
            txtruafunc.Clear();
            listtelefone.Items.Clear();

            txtcnh.Enabled = false;
            txtbairrofunc.Enabled = false;
            txtcargo.Enabled = false;
            txtcepfunc.Enabled = false;
            txtComplementofunc.Enabled = false;
            txtcpffunc.Enabled = false;
            txtfuncaofunc.Enabled = false;
            txtnascfunc.Enabled = false;
            txtnomefunc.Enabled = false;
            txtnumerofunc.Enabled = false;
            txtruafunc.Enabled = false;
            btnaddtel.Enabled = false;
            btnexcluirtel.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            btnlimpartel.Enabled = false;
            listtelefone.Enabled = false;
            mskpesquisar.Enabled = true;
            txtpesquisar.Enabled = true;
            btnalterar.Enabled = false;
            btnExlucir.Enabled = false;
            btnSalvar.Enabled = false;
            dgvfuncionario.Enabled = true;
        }

        private void btnaddtel_Click(object sender, EventArgs e)
        {
            listtelefone.Items.Add(txttelefone.Text);
            txttelefone.Clear();
        }

        private void btnexcluirtel_Click(object sender, EventArgs e)
        {
            listtelefone.Items.Remove(listtelefone.SelectedItem);
        }

        private void btnlimpartel_Click(object sender, EventArgs e)
        {
            listtelefone.Items.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txttelefone.Enabled = true;
            txttelefone.Mask = "(00)0000-0000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txttelefone.Enabled = true;
            txttelefone.Mask = "(00)00000-0000";
        }

        private void Exlucir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o funcionario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dgvfuncionario.DataSource = Func.preencherDataGrid();
                MessageBox.Show(Func.excluirCliente(cod));
                txtbairrofunc.Clear();
                txtcargo.Text = "";
                txtcepfunc.Clear();
                txtComplementofunc.Clear();
                txtcpffunc.Clear();
                txtfuncaofunc.Clear();
                txtnascfunc.Clear();
                txtnomefunc.Clear();
                txtnumerofunc.Clear();
                txtruafunc.Clear();
                listtelefone.Items.Clear();

                txtcnh.Enabled = false;
                txtbairrofunc.Enabled = false;
                txtcargo.Enabled = false;
                txtcepfunc.Enabled = false;
                txtComplementofunc.Enabled = false;
                txtcpffunc.Enabled = false;
                txtfuncaofunc.Enabled = false;
                txtnascfunc.Enabled = false;
                txtnomefunc.Enabled = false;
                txtnumerofunc.Enabled = false;
                txtruafunc.Enabled = false;
                btnaddtel.Enabled = false;
                btnexcluirtel.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                btnlimpartel.Enabled = false;
                listtelefone.Enabled = false;
                mskpesquisar.Enabled = true;
                txtpesquisar.Enabled = true;
                btnalterar.Enabled = false;
                btnExlucir.Enabled = false;
                btnSalvar.Enabled = false;
                dgvfuncionario.Enabled = true;
            }
        }

        private void dgvfuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dgvfuncionario.CurrentCell.RowIndex;

             dgvfuncionario.DataSource = Func.preencherDataGrid();
            DataGridViewRow row = this.dgvfuncionario.Rows[e.RowIndex];
            string codigoId = row.Cells["codFuncionario"].Value.ToString();
            cod = Convert.ToInt16(codigoId);

            listtelefone.Items.Clear();

            txtnomefunc.Text = dgvfuncionario[1, linhaAtual].Value.ToString();
            txtcnh.Text = dgvfuncionario[2, linhaAtual].Value.ToString();
            txtnascfunc.Text = dgvfuncionario[3, linhaAtual].Value.ToString();
            txtruafunc.Text = dgvfuncionario[4, linhaAtual].Value.ToString();
            txtbairrofunc.Text = dgvfuncionario[5, linhaAtual].Value.ToString();
            txtcepfunc.Text = dgvfuncionario[6, linhaAtual].Value.ToString();
            txtnumerofunc.Text = dgvfuncionario[7, linhaAtual].Value.ToString();
            txtComplementofunc.Text = dgvfuncionario[8, linhaAtual].Value.ToString();
            txtfuncaofunc.Text = dgvfuncionario[9, linhaAtual].Value.ToString();
            txtcpffunc.Text = dgvfuncionario[10, linhaAtual].Value.ToString();
            txtcargo.Text = dgvfuncionario[11, linhaAtual].Value.ToString();
            cmbEstado.Text = dgvfuncionario[12, linhaAtual].Value.ToString();

            btnalterar.Enabled = true;
            btnExlucir.Enabled = true;
            btnSalvar.Enabled = false;

            txtcnh.Enabled = false;
            txtbairrofunc.Enabled = false;
            txtcargo.Enabled = false;
            txtcepfunc.Enabled = false;
            txtComplementofunc.Enabled = false;
            txtcpffunc.Enabled = false;
            txtfuncaofunc.Enabled = false;
            txtnascfunc.Enabled = false;
            txtnomefunc.Enabled = false;
            txtnumerofunc.Enabled = false;
            txtruafunc.Enabled = false;
            btnaddtel.Enabled = false;
            btnexcluirtel.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            btnlimpartel.Enabled = false;
            listtelefone.Enabled = false;
            mskpesquisar.Enabled = true;
            txtpesquisar.Enabled = true;
            
            SqlCommand cmd = new SqlCommand("select count (codTelFuncionario)from tbTelFuncionario where codFuncionario = '" + cod + "'", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] telefones = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select telFuncionario from tbtelFuncionario where codFuncionario = '" + cod + "'", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                telefones[i] = siglas["telFuncionario"].ToString();
                i++;
            }

            c.desconectar();


            String[] listTel = telefones;
            for (int f = 0; f < listTel.Length; f++)
            {
                listtelefone.Items.Add(listTel[f]);

            }
            
        }

        private void txtpesquisar_Click(object sender, EventArgs e)
        {
            dgvfuncionario.DataSource = Func.pesquisacpf(txtpesquisar.Text);
            
            
        }

        private void txtalterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar o funcionario?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtcnh.Enabled = true;
                txtbairrofunc.Enabled = true;
                txtcargo.Enabled = true;
                txtcepfunc.Enabled = true;
                txtComplementofunc.Enabled = true;
                txtcpffunc.Enabled = true;
                txtfuncaofunc.Enabled = true;
                txtnascfunc.Enabled = true;
                txtnomefunc.Enabled = true;
                txtnumerofunc.Enabled = true;
                txtruafunc.Enabled = true;
                btnaddtel.Enabled = true;
                btnexcluirtel.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                btnlimpartel.Enabled = true;
                listtelefone.Enabled = true;
                mskpesquisar.Enabled = false;
                txtpesquisar.Enabled = false;
                alterar = 1;
                btnSalvar.Enabled = true;
            }
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
             if (!this.Propriedade.Equals(""))
            
                consul = this.Propriedade;
                 this.dgvfuncionario.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                 this.dgvfuncionario.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                SqlCommand cmd = new SqlCommand("select codFuncionario,nome ,cnh,dtnasc ,rua ,bairro ,cep,numero,complemento,descrFuncao,cpf,cargo,codEstado  from tbFuncionario where codFuncionario= '" + consul + "'", c.con);
               
                c.conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                {

                    if (dr.HasRows)
                    {
                        dr.Read();
                        codCli = dr["codFuncionario"].ToString();
                        txtnomefunc.Text = dr["nome"].ToString();
                        txtcnh.Text = dr["cnh"].ToString();
                        txtnascfunc.Text = dr["dtnasc"].ToString();
                        txtruafunc.Text = dr["rua"].ToString();                        
                        txtbairrofunc.Text = dr["bairro"].ToString();
                        txtcepfunc.Text = dr["cep"].ToString();
                        txtnumerofunc.Text = dr["numero"].ToString();
                        txtComplementofunc.Text = dr["complemento"].ToString();
                        txtfuncaofunc.Text = dr["descrFuncao"].ToString();
                        txtcpffunc.Text = dr["cpf"].ToString();
                        txtcargo.Text = dr["cargo"].ToString();
                        pesEstado = dr["codEstado"].ToString();
                       
                        cod = Convert.ToInt16(codCli);
                    }


                    c.desconectar();

                    try
                    {

                        c.conectar();
                        SqlCommand cmd4 = new SqlCommand("SELECT descrEstado from tbEstado where codEstado  like '" + pesEstado + "%'", c.con);

                        cmbEstado.Text = Convert.ToString(cmd4.ExecuteScalar());

                    }
                    catch (SqlException erro)
                    {
                        throw (erro);
                    }
                    finally
                    {
                        c.desconectar();


                    }

                    SqlCommand cmd3 = new SqlCommand("select count (codTelFuncionario)from tbTelFuncionario where codFuncionario = '" + cod + "'", c.con);
                    c.conectar();
                    int qtde = Convert.ToInt32(cmd3.ExecuteScalar());
                    String[] telefones = new String[qtde];

                    SqlCommand cmd2 = new SqlCommand("select telFuncionario from tbTelFuncionario where codFuncionario = '" + cod + "'", c.con);

                    var siglas = cmd2.ExecuteReader();

                    int i = 0;
                    while (siglas.Read())
                    {
                        telefones[i] = siglas["telFuncionario"].ToString();
                        i++;
                    }


                    c.desconectar();


                    String[] listTel = telefones;
                    for (int f = 0; f < listTel.Length; f++)
                    {
                        listtelefone.Items.Add(listTel[f]);

                    }
                    btnalterar.Enabled = true;
                    btnExlucir.Enabled = true;


                }
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void preencherCboEstado()
        {
            String[] lista = Func.carregarUf();

            for (int i = 0; i < lista.Length; i++)
            {
                cmbEstado.Items.Add(lista[i]);

            }
        }

        // preencher a combobox do cargo.
        public void carregarCargo()
        {
            String[] lista = Func.carregarCargo();

            for (int i = 0; i < lista.Length; i++)
            {
                txtcargo.Items.Add(lista[i]);

            }
        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            // pecando o codigo do cargo escolhido
            try
            {


                c.conectar();
                SqlCommand cmd = new SqlCommand("SELECT codEstado from tbEstado where descrEStado ='" + cmbEstado.Text + "'", c.con);

                est = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (SqlException erro)
            {
                throw (erro);
            }
            finally
            {
                c.desconectar();


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


       
        }
    }

