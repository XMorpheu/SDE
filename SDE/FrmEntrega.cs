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
using System.Drawing.Printing;


namespace SDE
{
    public partial class FrmEntrega : Form
    {
        conexao c = new conexao();
        ClassEntrega entre = new ClassEntrega();
        int vei, estEntre, mot, estadoRed, alterar = 0 ,codE;

        string codCli, consul;
        int PaginaAtual, PaginaTotal;
        string b,a;

        String stringSql;

        SqlDataReader Leitor;

        public FrmEntrega()
        {
            InitializeComponent();
            preencherCboVEi();
            preencherCboMot();
            preencherCboEstado();
            

        }


        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
         private void button1_Click(object sender, EventArgs e)
        {

            if (txtpsqcnpj.Text != string.Empty)
            {
                
                SqlCommand cmd = new SqlCommand("select codCliente,nome,cnpj,contato,rua,bairro,cep,numero,Complemento,codEstado from tbCliente "+
                    "where cnpj LIKE '" + txtpsqcnpj.Text + "%' ", c.con);
                
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
                        txtcomplemento.Text = dr["complemento"].ToString();
                        a = dr["codEstado"].ToString();
                        
                    }

                    c.desconectar();
                }



                SqlCommand cmd3 = new SqlCommand("SELECT MAX(numeroEntrega) FROM tbEntrega ", c.con);
                c.conectar();
                int numero =0;
               numero = Convert.ToInt32(cmd3.ExecuteScalar());
                if (numero == 0)
                {
                    numero = 1000;
                }
                txtNumeroPedido.Text = Convert.ToString(numero + 1);
                c.desconectar();

                try
                {

                    c.conectar();
                    SqlCommand cmds = new SqlCommand("SELECT descrEstado from tbEstado where codEstado  like '" + a + "%'", c.con);

                    cmbEst.Text = Convert.ToString(cmds.ExecuteScalar());

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
            else
            {
                                 
                 String menssagem = "O Campo de status está vazio. por favor digite o cnpj";
                 String titulo = "SDE";
                 MessageBox.Show(menssagem, titulo,
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Exclamation,
                         MessageBoxDefaultButton.Button1);
                
            }









        }

        private void btnnovo_Click(object sender, EventArgs e)
        {

            if (txtnome.Text != string.Empty)
            {
                btnSalvar.Enabled = true;
                dataGridView1.Visible = false;
                txtRuaentrega.Enabled = true;
                txtContatoEntrega.Enabled = true;
                txtBairroEntrega.Enabled = true;
                txtDescrEntrega.Enabled = true;
                txtNumeroNota.Enabled = true;
                txtVolumenota.Enabled = true;
                txtCepEntrega.Enabled = true;
                txtNumeroEntrega.Enabled = true;
                txtValorEntrega.Enabled = true;
                cmbEstado.Enabled = true;
                cmbMotorista.Enabled = true;
                cmbVeiculo.Enabled = true;
                dateTimePicker1.Enabled = true;
                cmbStatus.Enabled = true;
                cbmIda.Enabled = true;
                cmbStatus.Enabled = true;
                btnSalvar.Enabled = true;
                alterar = 0;




            }
            else
            {

                String menssagem = "Pesquise um cliente.";
                String titulo = "SDE";
                MessageBox.Show(menssagem, titulo,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1);



            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (txtRuaentrega.Text != string.Empty && txtBairroEntrega.Text != string.Empty &&
                txtCepEntrega.Text != string.Empty && txtContatoEntrega.Text != string.Empty &&
              txtNumeroEntrega.Text != string.Empty && txtVolumenota.Text != string.Empty &&
            txtValorEntrega.Text != string.Empty && cmbStatus.Text != string.Empty &&
                txtNumeroEntrega.Text != string.Empty && cmbMotorista.Text != string.Empty &&
                cmbVeiculo.Text != string.Empty && cmbEstado.Text != string.Empty &&
               txtbairro.Text != string.Empty && txtrua.Text != string.Empty &&
                txtcep.Text != string.Empty && txtnumero.Text != string.Empty &&
                cmbEst.Text != string.Empty)
            {

                if (alterar > 0)
                {
                    MessageBox.Show(entre.AlterarEntrega(txtRuaentrega.Text, txtBairroEntrega.Text, txtCepEntrega.Text, txtContatoEntrega.Text,
                        Convert.ToInt32(txtNumeroEntrega.Text), Convert.ToInt32(txtVolumenota.Text), txtDescrEntrega.Text, Convert.ToDouble(txtValorEntrega.Text),
                         cmbStatus.Text, cbmIda.Text, cmbVolta.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtNumeroEntrega.Text),
                         mot, vei, Convert.ToInt32(codCli), estEntre, txtbairro.Text, txtrua.Text, txtcep.Text, Convert.ToInt32(txtnumero.Text),
                         txtcomplemento.Text, txtcontato.Text, estadoRed, codE)+ MessageBoxIcon.Exclamation);

                    txtRuaentrega.Enabled = false;
                    txtContatoEntrega.Enabled = false;
                    txtBairroEntrega.Enabled = false;
                    txtDescrEntrega.Enabled = false;
                    txtNumeroNota.Enabled = false;
                    txtVolumenota.Enabled = false;
                    txtCepEntrega.Enabled = false;
                    txtNumeroEntrega.Enabled = false;
                    txtValorEntrega.Enabled = false;
                    cmbEstado.Enabled = false;

                    txtRuaentrega.Clear();
                    txtContatoEntrega.Clear();
                    txtBairroEntrega.Clear();
                    txtDescrEntrega.Clear();
                    txtNumeroNota.Clear();
                    txtVolumenota.Clear();
                    txtCepEntrega.Clear();
                    txtNumeroEntrega.Clear();
                    txtValorEntrega.Clear();
                    cmbEstado.Text = "";
                    txtpsqcnpj.Clear();
                    txtNumeroPedido.Clear();

                    txtnome.Clear();
                    txtcnpj.Clear();
                    txtcontato.Clear();
                    txtrua.Clear();
                    txtbairro.Clear();
                    txtcep.Clear();
                    txtnumero.Clear();
                    txtcomplemento.Clear();
                    cmbEst.Text = "";

                    txtcontato.Enabled = false;
                    txtrua.Enabled = false;
                    txtbairro.Enabled = false;
                    txtcep.Enabled = false;
                    txtnumero.Enabled = false;
                    txtcomplemento.Enabled = false;
                    cmbEst.Enabled = false;

                    cmbEstado.Enabled = false;
                    cmbMotorista.Enabled = false;
                    cmbVeiculo.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    cmbStatus.Enabled = false;
                    cbmIda.Enabled = false;
                    cmbStatus.Enabled = false;

                    txtNumeroEntrega.Clear();
                    txtNumeroEntrega.Enabled = false;

                    cmbEstado.Text = "";
                    cmbMotorista.Text = "";
                    cmbVeiculo.Text = "";
                    dateTimePicker1.Text = "";
                    cmbStatus.Text = "";
                    cbmIda.Text = "";
                    cmbStatus.Text = "";

                }

                else
                {
                    if (alterar == 0)
                    {


                        string a = dateTimePicker1.Text;
                        a = a.Substring(0, 10);
                        MessageBox.Show(entre.cadastrarEntrega(txtRuaentrega.Text, txtBairroEntrega.Text, txtCepEntrega.Text, txtContatoEntrega.Text,
                            Convert.ToInt32(txtNumeroEntrega.Text), Convert.ToInt32(txtVolumenota.Text), txtDescrEntrega.Text, Convert.ToDouble(txtValorEntrega.Text),
                            cmbStatus.Text, cbmIda.Text, cmbVolta.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtNumeroPedido.Text), Convert.ToInt32(txtNumeroNota.Text),
                            mot, vei, Convert.ToInt32(codCli), estEntre, txtbairro.Text, txtrua.Text, txtcep.Text, Convert.ToInt32(txtnumero.Text),
                            txtcomplemento.Text, txtcontato.Text, a, estadoRed));
                    }



                    txtRuaentrega.Enabled = false;
                    txtContatoEntrega.Enabled = false;
                    txtBairroEntrega.Enabled = false;
                    txtDescrEntrega.Enabled = false;
                    txtNumeroNota.Enabled = false;
                    txtVolumenota.Enabled = false;
                    txtCepEntrega.Enabled = false;
                    txtNumeroEntrega.Enabled = false;
                    txtValorEntrega.Enabled = false;
                    cmbEstado.Enabled = false;

                    txtRuaentrega.Clear();
                    txtContatoEntrega.Clear();
                    txtBairroEntrega.Clear();
                    txtDescrEntrega.Clear();
                    txtNumeroNota.Clear();
                    txtVolumenota.Clear();
                    txtCepEntrega.Clear();
                    txtNumeroEntrega.Clear();
                    txtValorEntrega.Clear();
                    cmbEstado.Text = "";
                    txtpsqcnpj.Clear();
                    txtNumeroPedido.Clear();


                    txtnome.Clear();
                    txtcnpj.Clear();
                    txtcontato.Clear();
                    txtrua.Clear();
                    txtbairro.Clear();
                    txtcep.Clear();
                    txtnumero.Clear();
                    txtcomplemento.Clear();
                    cmbEst.Text = "";

                    txtcontato.Enabled = false;
                    txtrua.Enabled = false;
                    txtbairro.Enabled = false;
                    txtcep.Enabled = false;
                    txtnumero.Enabled = false;
                    txtcomplemento.Enabled = false;
                    cmbEst.Enabled = false;

                    cmbEstado.Enabled = false;
                    cmbMotorista.Enabled = false;
                    cmbVeiculo.Enabled = false;
                    dateTimePicker1.Enabled = false;
                    cmbStatus.Enabled = false;
                    cbmIda.Enabled = false;
                    cmbStatus.Enabled = false;

                    txtNumeroEntrega.Clear();
                    txtNumeroEntrega.Enabled = false;

                    cmbEstado.Text = "";
                    cmbMotorista.Text = "";
                    cmbVeiculo.Text = "";
                    dateTimePicker1.Text = "";
                    cmbStatus.Text = "";
                    cbmIda.Text = "";
                    cmbStatus.Text = "";

                }

            }

            else
            {
                MessageBox.Show("Os campos com (*) são obrigatórios.");
            }


        }


        public void preencherCboVEi()
        {
            String[] lista = entre.carregarVei();

            for (int i = 0; i < lista.Length; i++)
            {
                cmbVeiculo.Items.Add(lista[i]);

            }
        }

        public void preencherCboEstado()
        {
            String[] lista = entre.carregarEstado();

            for (int i = 0; i < lista.Length; i++)
            {
                cmbEstado.Items.Add(lista[i]);
                cmbEst.Items.Add(lista[i]);

            }
        }

        private void cmbVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ufCliente = cmbVeiculo.SelectedItem.ToString();

            try
            {


                c.conectar();
                SqlCommand cmd = new SqlCommand("SELECT codVeiculo from tbVeiculo where modelo ='" + cmbVeiculo.Text + "'", c.con);

                vei = Convert.ToInt32(cmd.ExecuteScalar());

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

        public void preencherCboMot()
        {
            String[] listaUf = entre.carregarfunc();

            for (int i = 0; i < listaUf.Length; i++)
            {
                cmbMotorista.Items.Add(listaUf[i]);

            }
        }



        private void cmbMotorista_SelectedIndexChanged(object sender, EventArgs e)
        {


            try
            {


                c.conectar();
                SqlCommand cmd = new SqlCommand("SELECT codFuncionario from tbFuncionario where nome ='" + cmbMotorista.Text + "'", c.con);

                mot = Convert.ToInt32(cmd.ExecuteScalar());

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



        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //variaveis das linhas
            float linhasPorPagina = 0;
            float PosicaoDaLinha = 0;
            int LinhaAtual = 0;


            //Variavel para Passar um Traço

            Pen Risco = new Pen(Color.Black, 2);


            //Define as Fontes

            Font FonteNegrito = new Font("Times New Romam", 9, FontStyle.Bold);
            Font FonteTitulo = new Font("Times New Roman ", 15, FontStyle.Bold);
            Font FonteSubtitulo = new Font("Times New Roman", 12, FontStyle.Bold);

            Font FonteRodape = new Font("Arial", 8);
            Font FonteNormal = new Font("Arial", 9);



            //cabeçalho


            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 40, e.MarginBounds.Right, 40);
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 170, e.MarginBounds.Right, 170);

            //Titulo

            e.Graphics.DrawString("                                                                 " + System.DateTime.Now, FonteTitulo, Brushes.Black, e.MarginBounds.Left + 10, 50, new StringFormat());



            // Imagem

            e.Graphics.DrawString("Lista de Clientes", FonteSubtitulo, Brushes.Black, e.MarginBounds.Left + 250, 150, new StringFormat());

            // Create image.
            Image newImage = Image.FromFile("Image/Logo.jpg");

            // Create coordinates for upper-left corner.

            // of image and for size of image.
            int x = 80;
            int y = 45;
            int width = 233;
            int height = 100;

            // Draw image to screen.
            e.Graphics.DrawImage(newImage, x, y, width, height);



            // Campos a Serem Impressos : Código , Nome e RG


            e.Graphics.DrawString("Nome", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 50, 171, new StringFormat());
            e.Graphics.DrawString("CNPJ", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 200, 171, new StringFormat());
            e.Graphics.DrawString("CEP", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 350, 171, new StringFormat());
            e.Graphics.DrawString("Bairro", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 500, 171, new StringFormat());
            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, 190, e.MarginBounds.Right, 190);



            //Linha por pagina


            linhasPorPagina = Convert.ToInt32(e.MarginBounds.Height / FonteNormal.GetHeight(e.Graphics) - 9);


            //Aqui São Lidos os Dados

            while ((LinhaAtual < linhasPorPagina && Leitor.Read()))
            {

                //Obtém os valores do DataReader

                String nome = Leitor.GetString(0);
                String rg = Leitor.GetString(1);
                String cpf = Leitor.GetString(2);
                String cidade = Leitor.GetString(3);




                // Inicia a Impressão

                PosicaoDaLinha = e.MarginBounds.Top + 100 + (LinhaAtual * FonteNormal.GetHeight(e.Graphics));
                e.Graphics.DrawString(nome.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 50, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(rg.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 200, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(cpf.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 350, PosicaoDaLinha, new StringFormat());
                e.Graphics.DrawString(cidade.ToString(), FonteNormal, Brushes.Black, e.MarginBounds.Left + 500, PosicaoDaLinha, new StringFormat());
                LinhaAtual += 1;

            }


            //Rodapé

            e.Graphics.DrawLine(Risco, e.MarginBounds.Left, e.MarginBounds.Bottom, e.MarginBounds.Right, e.MarginBounds.Bottom);
            e.Graphics.DrawString(System.DateTime.Now.ToString(), FonteRodape, Brushes.Black, e.MarginBounds.Right - 105, e.MarginBounds.Bottom, new StringFormat());
            LinhaAtual += Convert.ToInt32(FonteNormal.GetHeight(e.Graphics));
            LinhaAtual += 1;
            e.Graphics.DrawString("Página : " + PaginaAtual + "  De  " + PaginaTotal, FonteRodape, Brushes.Black, e.MarginBounds.Right - 625, e.MarginBounds.Bottom, new StringFormat());


            //Incrementa o Número da Pagina


            PaginaAtual += 1;
            PaginaTotal = PaginaAtual;


            // Verifica se Continua Imprimindo

            if ((LinhaAtual > linhasPorPagina))
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }

        private void printDocument1_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            SqlCommand cmd = new SqlCommand(stringSql, c.con);
            c.conectar();
            Leitor = cmd.ExecuteReader();
            PaginaAtual = 1;
            PaginaTotal = PaginaAtual;
        }

        private void printDocument1_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //Fecha o DataReader

            Leitor.Close();

            // Fecha a Conexão
            c.desconectar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcontato.Enabled = true;
            txtrua.Enabled = true;
            txtbairro.Enabled = true;
            txtcep.Enabled = true;
            txtnumero.Enabled = true;
            txtcomplemento.Enabled = true;
            cmbEst.Enabled = true;
        }

        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                c.conectar();
                SqlCommand cmd = new SqlCommand("SELECT codEstado from tbEstado where descrEStado ='" + cmbEstado.Text + "'", c.con);

                estEntre = Convert.ToInt32(cmd.ExecuteScalar());

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbEst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {


                c.conectar();
                SqlCommand cmd = new SqlCommand("SELECT codEstado from tbEstado where descrEStado ='" + cmbEst.Text + "'", c.con);

                estadoRed = Convert.ToInt32(cmd.ExecuteScalar());

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

        private void btnExlucir_Click(object sender, EventArgs e)
        {
            int i = 0;
            i = Convert.ToInt32(consul);

            if (MessageBox.Show("Deseja realmente excluir a Entrega ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (i > 0)
                {
                    MessageBox.Show(entre.excluirEntrega(i));
                }
                else
                {
                    MessageBox.Show("consulte uma Entrega");
                }

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            btnSalvar.Enabled = false;
            txtRuaentrega.Enabled = false;
            txtContatoEntrega.Enabled = false;
            txtBairroEntrega.Enabled = false;
            txtDescrEntrega.Enabled = false;
            txtNumeroNota.Enabled = false;
            txtVolumenota.Enabled = false;
            txtCepEntrega.Enabled = false;
            txtNumeroEntrega.Enabled = false;
            txtValorEntrega.Enabled = false;
            cmbEstado.Enabled = false;

            txtNumeroPedido.Clear();
            txtRuaentrega.Clear();
            txtContatoEntrega.Clear();
            txtBairroEntrega.Clear();
            txtDescrEntrega.Clear();
            txtNumeroNota.Clear();
            txtVolumenota.Clear();
            txtCepEntrega.Clear();
            txtNumeroEntrega.Clear();
            txtValorEntrega.Clear();
            cmbEstado.Text = "";
            txtpsqcnpj.Clear();


            txtnome.Clear();
            txtcnpj.Clear();
            txtcontato.Clear();
            txtrua.Clear();
            txtbairro.Clear();
            txtcep.Clear();
            txtnumero.Clear();
            txtcomplemento.Clear();
            cmbEst.Text = "";

            cmbEstado.Text = "";
            cmbMotorista.Text = "";
            cmbVeiculo.Text = "";
            dateTimePicker1.Text = "";
            cmbStatus.Text = "";
            cbmIda.Text = "";
            cmbStatus.Text = "";

            txtcontato.Enabled = false;
            txtrua.Enabled = false;
            txtbairro.Enabled = false;
            txtcep.Enabled = false;
            txtnumero.Enabled = false;
            txtcomplemento.Enabled = false;
            cmbEst.Enabled = false;

            cmbEstado.Enabled = false;
            cmbMotorista.Enabled = false;
            cmbVeiculo.Enabled = false;
            dateTimePicker1.Enabled = false;
            cmbStatus.Enabled = false;
            cbmIda.Enabled = false;
            cmbStatus.Enabled = false;
            
            txtNumeroEntrega.Clear();
            txtNumeroEntrega.Enabled=false;

           


        }

        private void txtalterar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente alterar a Entrega ?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (txtpsqcnpj.Text != string.Empty)
                {
                    alterar = 1;

                    btnSalvar.Enabled = true;
                    txtRuaentrega.Enabled = true;
                    txtContatoEntrega.Enabled = true;
                    txtBairroEntrega.Enabled = true;
                    txtDescrEntrega.Enabled = true;
                    txtNumeroNota.Enabled = true;
                    txtVolumenota.Enabled = true;
                    txtCepEntrega.Enabled = true;
                    txtNumeroEntrega.Enabled = true;
                    txtValorEntrega.Enabled = true;
                    cmbEstado.Enabled = true;
                    cmbEstado.Enabled = true;
                    cmbMotorista.Enabled = true;
                    cmbVeiculo.Enabled = true;
                    cmbStatus.Enabled = true;
                    cmbVolta.Enabled = true;
                    cmbStatus.Enabled = true;





                }

                else
                {

                    String menssagem = "Pesquise um cliente.";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);



                }

            }
        }

        public FrmEntrega(string valor)
        {
            InitializeComponent();
            consul = valor;
            
        }


        public string Propriedade { get; set; }



        private void FrmEntrega_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
            btnExlucir.Enabled = false;            
            txtalterar.Enabled = false;
            btnSalvar.Enabled = false;
            txtNumeroPedido.Enabled = false;
            if (!this.Propriedade.Equals(""))
            {
                this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
                this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
                dataGridView1.Visible = true;
                btnExlucir.Enabled = true;
                txtalterar.Enabled = true;
                consul = this.Propriedade;
                codE = Convert.ToInt32(consul);


                MessageBox.Show("" + consul);

                dataGridView1.DataSource = entre.Consulta(codE);


            }

            
        

            


        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            alterar = 0;
            int linhaAtual = dataGridView1.CurrentCell.RowIndex;
            string codFuncionario = dataGridView1[0, linhaAtual].Value.ToString();
           

           // txtRuaentrega.Text = dataGridView1[1, linhaAtual].Value.ToString();
            txtRuaentrega.Text = dataGridView1[1, linhaAtual].Value.ToString();
            txtBairroEntrega.Text = dataGridView1[2, linhaAtual].Value.ToString();
            txtCepEntrega.Text = dataGridView1[3, linhaAtual].Value.ToString();
            txtContatoEntrega.Text = dataGridView1[4, linhaAtual].Value.ToString();
            txtNumeroEntrega.Text = dataGridView1[5, linhaAtual].Value.ToString();
            txtVolumenota.Text = dataGridView1[6, linhaAtual].Value.ToString();
            txtDescrEntrega.Text = dataGridView1[7, linhaAtual].Value.ToString();
            txtValorEntrega.Text = dataGridView1[8, linhaAtual].Value.ToString();
            cmbStatus.Text = dataGridView1[9, linhaAtual].Value.ToString();
            cbmIda.Text = dataGridView1[10, linhaAtual].Value.ToString();
            txtNumeroPedido.Text = dataGridView1[11, linhaAtual].Value.ToString();
            txtNumeroNota.Text = dataGridView1[12, linhaAtual].Value.ToString();
            txtbairro.Text = dataGridView1[13, linhaAtual].Value.ToString();
            txtrua.Text = dataGridView1[14, linhaAtual].Value.ToString();
            txtcep.Text = dataGridView1[15,linhaAtual].Value.ToString();
            txtnumero.Text = dataGridView1[16, linhaAtual].Value.ToString();
            txtcomplemento.Text = dataGridView1[17, linhaAtual].Value.ToString();
          // data.Text = dataGridView1[18, linhaAtual].Value.ToString();
            txtnome.Text = dataGridView1[19, linhaAtual].Value.ToString();
            txtcnpj.Text = dataGridView1[20, linhaAtual].Value.ToString();
            cmbVeiculo.Text = dataGridView1[21, linhaAtual].Value.ToString();
            cmbMotorista.Text = dataGridView1[22, linhaAtual].Value.ToString();
            cmbEstado.Text = dataGridView1[23, linhaAtual].Value.ToString();
           b = dataGridView1[24, linhaAtual].Value.ToString();
            txtcontato.Text = dataGridView1[25, linhaAtual].Value.ToString();
            codCli = dataGridView1[26, linhaAtual].Value.ToString();
            cmbVolta.Text = dataGridView1[27, linhaAtual].Value.ToString();
            try
            {
                
                c.conectar();
                SqlCommand cmd = new SqlCommand("SELECT descrEstado from tbEstado where codEstado  like '" + b + "%'", c.con);

                cmbEst.Text = Convert.ToString(cmd.ExecuteScalar());

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

    

