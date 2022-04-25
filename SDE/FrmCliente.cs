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
    public partial class FrmCliente : Form
    {
        conexao c = new conexao();
        ClassCliente cli = new ClassCliente();
        int cod;
        int est;
        int cods;
        int alterar;
        string codCli;
        string consul,pesEstado;

        public FrmCliente()
        {
            InitializeComponent();
            preencherCboEstado();
            dgvCliente.DataSource = cli.preencherDataGrid();
            dgvCliente.Columns[0].Visible = false;
            dgvCliente.Columns[1].Width = 180;
            dgvCliente.Columns[2].Width = 120;
            txtalterar.Enabled = false;
            btnExlucir.Enabled = false;
            btnSalvar.Enabled = false;
             this.dgvCliente.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                 this.dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

        }

        public FrmCliente(string valor)
                {
                    InitializeComponent();
                    preencherCboEstado();
                    dgvCliente.DataSource = cli.preencherDataGrid();
                    dgvCliente.Columns[0].Visible = false;
                    dgvCliente.Columns[1].Width = 180;
                    dgvCliente.Columns[2].Width = 120;
                    this.dgvCliente.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                    this.dgvCliente.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                    txtalterar.Enabled = false;
                    btnExlucir.Enabled = false;
                    btnSalvar.Enabled = false;
                    consul = valor;
               }

        
           public string Propriedade { get; set; }

        
       
        


        private void btnnovo_Click(object sender, EventArgs e)
        {
            txtnome.Enabled = true;
            txtrua.Enabled = true;
            txtnumero.Enabled = true;
            txtComplemento.Enabled = true;
            txtcnpj.Enabled = true;
            txtbairro.Enabled = true;
            txtcep.Enabled = true;
            txtcontato.Enabled = true;
            txttelefone.Enabled = true;
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            btnaddtel.Enabled = true;
            btnexcluirtel.Enabled = true;
            btnlimpartel.Enabled = false;
            dgvCliente.Enabled = false;
            txtpsqcnpj.Enabled = false;
            button1.Enabled = false;
            btnSalvar.Enabled = true;
            btnExlucir.Enabled = false;
            txtalterar.Enabled = false;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

           
            String val = txtcnpj.Text;
            int consulta = cli.Consultarcnpj(Convert.ToString(txtcnpj.Text));

            // verificação dos campos obrigatório.
            if (txtnome.Text != string.Empty
               && txtcep.Text != string.Empty && txtcontato.Text != string.Empty
               && txtnumero.Text != string.Empty && txtrua.Text != string.Empty)
            {


                // validação de cnpj.
                if (validacao.ValidaCNPJ(val))
                {
                    String nome = txtnome.Text;

                    // validação de nome.
                    if (validacao.ValidaNome(nome))
                    {
                        // laço para o telefone
                        String[] numTelCli = new String[listtelefone.Items.Count];

                        for (int i = 0; i < listtelefone.Items.Count; i++)
                        {
                            numTelCli[i] = listtelefone.Items[i].ToString();

                        }

                        // vericação para alterar ou salvar.
                        if (alterar > 0)
                        {
                            MessageBox.Show(cli.alterarCliente(txtnome.Text, val, txtcontato.Text, txtrua.Text, txtbairro.Text,
                           txtcep.Text, txtnumero.Text, txtComplemento.Text,est ,listtelefone.Items.Count, numTelCli, cod));
                            alterar = 0;
                          

                            //limpando formulario
                            txtnome.Clear();
                            txtrua.Clear();
                            txtnumero.Clear();
                            txtComplemento.Clear();
                            txtcnpj.Clear();
                            txtbairro.Clear();
                            txtcep.Clear();
                            txtcontato.Clear();
                            txttelefone.Clear();
                            listtelefone.Items.Clear();


                            
                            txtnome.Enabled = false;
                            txtrua.Enabled = false;
                            txtnumero.Enabled = false;
                            txtComplemento.Enabled = false;
                            txtcnpj.Enabled = false;
                            txtbairro.Enabled = false;
                            txtcep.Enabled = false;
                            txtcontato.Enabled = false;
                            txttelefone.Enabled = false;
                            radioButton1.Enabled = false;
                            radioButton2.Enabled = false;
                            btnaddtel.Enabled = false;
                            btnlimpartel.Enabled = false;
                            btnexcluirtel.Enabled = false;
                            btnlimpartel.Enabled = false;
                            dgvCliente.Enabled = true;
                            txtpsqcnpj.Enabled = true;
                            button1.Enabled = true;
                            btnSalvar.Enabled = false;
                            txtalterar.Enabled = false;
                            btnExlucir.Enabled = false;
                            
                        }
                        // se não for alterar ira salvar. 
                        else
                        {
                            // verificação se já o cnpj já está cadastrado 

                            if (consulta == 0)
                            {
                                MessageBox.Show(cli.cadastrarCliente(txtnome.Text, val, txtcontato.Text, txtrua.Text, txtbairro.Text,
                                txtcep.Text, txtnumero.Text, txtComplemento.Text,est, listtelefone.Items.Count, numTelCli));

                                //limpando formulario
                                txtnome.Clear();
                                txtrua.Clear();
                                txtnumero.Clear();
                                txtComplemento.Clear();
                                txtcnpj.Clear();
                                txtbairro.Clear();
                                txtcep.Clear();
                                txtcontato.Clear();
                                txttelefone.Clear();
                                listtelefone.Items.Clear();

                                txtnome.BackColor = Color.White;
                                txtnome.Enabled = false;
                                txtrua.Enabled = false;
                                txtnumero.Enabled = false;
                                txtComplemento.Enabled = false;
                                txtcnpj.Enabled = false;
                                txtbairro.Enabled = false;
                                txtcep.Enabled = false;
                                txtcontato.Enabled = false;
                                txttelefone.Enabled = false;
                                radioButton1.Enabled = false;
                                radioButton2.Enabled = false;
                                btnaddtel.Enabled = false;
                                btnlimpartel.Enabled = false;
                                btnexcluirtel.Enabled = false;
                                btnlimpartel.Enabled = false;
                                dgvCliente.Enabled = true;
                                txtpsqcnpj.Enabled = true;
                                button1.Enabled = true;
                                btnSalvar.Enabled = false;
                                txtalterar.Enabled = false;
                                btnExlucir.Enabled = false;
                                
                            }

                            else
                            {
                                String menssagem = "CNPJ Já Cadastrado";
                                String titulo = "SDE";
                                MessageBox.Show(menssagem, titulo,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation,
                                        MessageBoxDefaultButton.Button1);
                            }

                        }

                        dgvCliente.DataSource = cli.preencherDataGrid();


                    }
                    // se o nome não for valido.
                    else
                    {
                        String menssagem = "Nome Invalido";
                        String titulo = "SDE";
                        MessageBox.Show(menssagem, titulo,
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
                        txtnome.BackColor = Color.LightSteelBlue;
                    }

                }
                    // caso o cnpj seja invaliso 
                else
                {
                    String menssagem = "CNPJ Invalido";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                    txtcnpj.BackColor = Color.LightSteelBlue;
                }

                
            }
                // caso os campos de preenchemeno obrigatório não estejam preenchidos  
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
            txtnome.Clear();
            txtrua.Clear();
            txtnumero.Clear();
            txtComplemento.Clear();
            txtcnpj.Clear();
            txtbairro.Clear();
            txtcep.Clear();
            txtcontato.Clear();
            txttelefone.Clear();
            listtelefone.Items.Clear();

            txtnome.BackColor = Color.White;
            txtnome.Enabled = false;
            txtrua.Enabled = false;
            txtnumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtcnpj.Enabled = false;
            txtbairro.Enabled = false;
            txtcep.Enabled = false;
            txtcontato.Enabled = false;
            txttelefone.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            btnaddtel.Enabled = false;
            btnlimpartel.Enabled = false;
            btnexcluirtel.Enabled = false;
            txtpsqcnpj.Enabled = true;
            button1.Enabled = true;
            dgvCliente.Enabled = true;
            alterar = 0;
            txtalterar.Enabled = false;
            btnExlucir.Enabled = false;
            btnSalvar.Enabled = false;
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvCliente.DataSource = cli.pesquisaExatacnpj(txtpsqcnpj.Text);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txttelefone.Enabled = true;
            txttelefone.Mask = "(00)00000-0000";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txttelefone.Enabled = true;
            txttelefone.Mask = "(00)0000-0000";
        }

        private void dgvCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnome.Clear();
            txtrua.Clear();
            txtnumero.Clear();
            txtComplemento.Clear();
            txtcnpj.Clear();
            txtbairro.Clear();
            txtcep.Clear();
            txtcontato.Clear();
            txttelefone.Clear();
            listtelefone.Items.Clear();
             int linhaAtual = dgvCliente.CurrentCell.RowIndex;


            dgvCliente.DataSource = cli.preencherDataGrid();
            DataGridViewRow row = this.dgvCliente.Rows[e.RowIndex];
            string codigoId = row.Cells["codCliente"].Value.ToString();
            cod = Convert.ToInt16(codigoId);


            txtnome.Text = dgvCliente[1, linhaAtual].Value.ToString();
            txtcnpj.Text = dgvCliente[2, linhaAtual].Value.ToString();
           
            txtcontato.Text = dgvCliente[3, linhaAtual].Value.ToString();
            txtrua.Text = dgvCliente[4, linhaAtual].Value.ToString();
            txtbairro.Text = dgvCliente[5, linhaAtual].Value.ToString();
            txtcep.Text = dgvCliente[6, linhaAtual].Value.ToString();
            txtnumero.Text = dgvCliente[7, linhaAtual].Value.ToString();
            txtComplemento.Text = dgvCliente[8, linhaAtual].Value.ToString();
            cmbEstado.Text = dgvCliente[9, linhaAtual].Value.ToString();
           
            txtnome.Enabled = false;
            txtrua.Enabled = false;
            txtnumero.Enabled = false;
            txtComplemento.Enabled = false;
            txtcnpj.Enabled = false;
            txtbairro.Enabled = false;
            txtcep.Enabled = false;
            txtcontato.Enabled = false;
            txttelefone.Enabled = false;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            btnaddtel.Enabled = false;
            btnlimpartel.Enabled = false;
            btnexcluirtel.Enabled = false;
           


            SqlCommand cmd = new SqlCommand("select count (codTelCliente)from tbTelCliente where codCliente = '" + cod + "'", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] telefones = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select telcliente from tbTelCliente where codCliente = '" + cod + "'", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                telefones[i] = siglas["telcliente"].ToString();
                i++;
            } 
           

            c.desconectar();


            String[] listTel = telefones;
            for (int f = 0; f < listTel.Length; f++)
            {
                listtelefone.Items.Add(listTel[f]);

            }
            txtalterar.Enabled = true;
            btnExlucir.Enabled = true;

        }

        private void listtelefone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnaddtel_Click(object sender, EventArgs e)
        {
            listtelefone.Items.Add(txttelefone.Text);
            txttelefone.Clear();
        }

        private void txtalterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtnome.Enabled = true;
                txtrua.Enabled = true;
                txtnumero.Enabled = true;
                txtComplemento.Enabled = true;
                txtcnpj.Enabled = true;
                txtbairro.Enabled = true;
                txtcep.Enabled = true;
                txtcontato.Enabled = true;
                txttelefone.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                btnaddtel.Enabled = true;
                btnexcluirtel.Enabled = true;
                btnlimpartel.Enabled = true;
                dgvCliente.Enabled = false;
                txtpsqcnpj.Enabled = false;
                button1.Enabled = false;
                listtelefone.Enabled = true;
                btnSalvar.Enabled = true;
                alterar = 1;
            }
        }

        private void btnExlucir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir o cliente?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                MessageBox.Show(cli.excluirCliente(cod));
                dgvCliente.DataSource = cli.preencherDataGrid();
                txtnome.Clear();
                txtrua.Clear();
                txtnumero.Clear();
                txtComplemento.Clear();
                txtcnpj.Clear();
                txtbairro.Clear();
                txtcep.Clear();
                txtcontato.Clear();
                txttelefone.Clear();
                listtelefone.Items.Clear();

                txtnome.Enabled = false;
                txtrua.Enabled = false;
                txtnumero.Enabled = false;
                txtComplemento.Enabled = false;
                txtcnpj.Enabled = false;
                txtbairro.Enabled = false;
                txtcep.Enabled = false;
                txtcontato.Enabled = false;
                txttelefone.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                btnaddtel.Enabled = false;
                btnexcluirtel.Enabled = false;
                txtpsqcnpj.Enabled = true;
                button1.Enabled = true;
                dgvCliente.Enabled = true;
                txtalterar.Enabled = false;
                btnExlucir.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            String val = txtcnpj.Text;
            String[] numTelCli = new String[listtelefone.Items.Count];

            for (int i = 0; i < listtelefone.Items.Count; i++)
            {
                numTelCli[i] = listtelefone.Items[i].ToString();

                MessageBox.Show(cli.alterarCliente(txtnome.Text, val, txtcontato.Text, txtrua.Text, txtbairro.Text,
                        txtcep.Text, txtnumero.Text, txtComplemento.Text,est, listtelefone.Items.Count, numTelCli,cod));
            }


        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
             

            if (!this.Propriedade.Equals(""))
            {
                consul = this.Propriedade;
                 SqlCommand cmd = new SqlCommand("select codCliente,nome,cnpj,contato,rua,bairro,cep,numero,Complemento,codEstado from tbCliente where codCliente= '" + consul + "'", c.con);
                
                c.conectar();
                SqlDataReader dr = cmd.ExecuteReader();
                {

                    if (dr.HasRows)
                    {
                        dr.Read();
                        codCli = dr["codCliente"].ToString();
                        txtnome.Text = dr["Nome"].ToString();
                        txtcnpj.Text = dr["cnpj"].ToString();
                        txtcontato.Text = dr["contato"].ToString();
                        txtrua.Text = dr["rua"].ToString();
                        txtbairro.Text = dr["bairro"].ToString();
                        txtcep.Text = dr["cep"].ToString();
                        txtnumero.Text = dr["numero"].ToString();
                        txtComplemento.Text = dr["complemento"].ToString();
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
           




                   SqlCommand cmd3= new SqlCommand("select count (codTelCliente)from tbTelCliente where codCliente = '" + cod + "'", c.con);
                   c.conectar();
                   int qtde = Convert.ToInt32(cmd3.ExecuteScalar());
                   String[] telefones = new String[qtde];

                   SqlCommand cmd2 = new SqlCommand("select telcliente from tbTelCliente where codCliente = '" + cod + "'", c.con);

                   var siglas = cmd2.ExecuteReader();

                   int i = 0;
                   while (siglas.Read())
                   {
                       telefones[i] = siglas["telcliente"].ToString();
                       i++;
                   }


                   c.desconectar();


                   String[] listTel = telefones;
                   for (int f = 0; f < listTel.Length; f++)
                   {
                       listtelefone.Items.Add(listTel[f]);

                   }
                   txtalterar.Enabled = true;
                   btnExlucir.Enabled = true;


                }
                }
              
                }
        

        private void btnexcluirtel_Click(object sender, EventArgs e)
        {
            listtelefone.Items.Remove(listtelefone.SelectedItem);
        }

        private void btnlimpartel_Click(object sender, EventArgs e)
        {

            listtelefone.Items.Clear();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        public void preencherCboEstado()
        {
            String[] lista = cli.carregarUf();

            for (int i = 0; i < lista.Length; i++)
            {
                cmbEstado.Items.Add(lista[i]);
                
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
    }


}
    
       
        

     
