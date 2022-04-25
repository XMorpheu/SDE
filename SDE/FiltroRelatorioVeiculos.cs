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
    public partial class FiltroRelatorioVeiculos : Form
    {
        conexao c = new conexao();

        int PaginaAtual, PaginaTotal;
        String stringSql;

        SqlDataReader Leitor;
        public FiltroRelatorioVeiculos()
        {
            InitializeComponent();
        }

        private void btnPornomeCli_Click(object sender, EventArgs e)
        {
        
            


            //define os objetos printdocument e os Eventos Associados

            PrintDocument pd = new PrintDocument();

            // importante -eventos para definimos 3 eventos para tratar a
            //impressao : pringPage , BeginPrint eEndPrint


            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            pd.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
            pd.EndPrint += new PrintEventHandler(this.printDocument1_EndPrint);


            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();

            // Define o Objeto para Visualisar a Impressão

            try
            {

                //Define o Formulario como Maximizado e com Zoom

                {

                    objPrintPreview.Document = pd;
                    objPrintPreview.WindowState = FormWindowState.Maximized;
                    objPrintPreview.PrintPreviewControl.Zoom = 1;
                    objPrintPreview.Text = "Relatorio de Clientes";
                    objPrintPreview.ShowDialog();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            stringSql = "SELECT MARCA,COR,CHASSI,RODIZIO FROM tbveiculo";


            //define os objetos printdocument e os Eventos Associados

            PrintDocument pd = new PrintDocument();

            // importante -eventos para definimos 3 eventos para tratar a
            //impressao : pringPage , BeginPrint eEndPrint


            pd.PrintPage += new PrintPageEventHandler(this.printDocument1_PrintPage);
            pd.BeginPrint += new PrintEventHandler(this.printDocument1_BeginPrint);
            pd.EndPrint += new PrintEventHandler(this.printDocument1_EndPrint);


            PrintPreviewDialog objPrintPreview = new PrintPreviewDialog();

            // Define o Objeto para Visualisar a Impressão

            try
            {

                //Define o Formulario como Maximizado e com Zoom

                {

                    objPrintPreview.Document = pd;
                    objPrintPreview.WindowState = FormWindowState.Maximized;
                    objPrintPreview.PrintPreviewControl.Zoom = 1;
                    objPrintPreview.Text = "Relatorio de Clientes";
                    objPrintPreview.ShowDialog();

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cbmPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            
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

            e.Graphics.DrawString("Lista de Veículos", FonteSubtitulo, Brushes.Black, e.MarginBounds.Left + 250, 150, new StringFormat());

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


            e.Graphics.DrawString("Marca", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 50, 171, new StringFormat());
            e.Graphics.DrawString("Cor", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 200, 171, new StringFormat());
            e.Graphics.DrawString("Chassi", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 350, 171, new StringFormat());
            e.Graphics.DrawString("Rodizio", FonteNegrito, Brushes.Black, e.MarginBounds.Left + 500, 171, new StringFormat());
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

        private void btnPordataCli_Click(object sender, EventArgs e)
        {

        }

        private void FiltroRelatorioVeiculos_Load(object sender, EventArgs e)
        {

        }
    }
}
