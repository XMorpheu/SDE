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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
          
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente cad = new FrmCliente();
            cad.ShowDialog();

        }

        private void cadastroVeiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmVeiculo vei = new FrmVeiculo();
            vei.ShowDialog();
        }

        private void cadastroFuncionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario fun = new FrmFuncionario();
            fun.ShowDialog();

        }

        private void btncalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc");
        }

        private void btngoogle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.google.com.br/maps/preview");
        }

        private void btnWord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void btnExel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        private void estadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstado estado = new FrmEstado();
            estado.ShowDialog();

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Backup a = new Backup();

            MessageBox.Show(a.backupp());

        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string lblCaminho;
            Backup b = new Backup();
            OpenFileDialog ofdArquivo = new OpenFileDialog();

            ofdArquivo.Filter = "ARQUIVO DE BACKUP|*.bak";
            ofdArquivo.ShowDialog();
            lblCaminho = ofdArquivo.FileName;

            MessageBox.Show("" + lblCaminho);
            MessageBox.Show(b.restautar(lblCaminho));
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroRelatoriosCliente cad = new FiltroRelatoriosCliente();
            cad.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void entregaToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmEntrega ent = new FrmEntrega ();
            ent.ShowDialog();
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroRelatoriosFuncionarios ent = new FiltroRelatoriosFuncionarios();
            ent.ShowDialog();
        }

        private void localizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void veiculoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltroRelatorioVeiculos ent = new FiltroRelatorioVeiculos();
            ent.ShowDialog();
        }

        private void entregaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FiltroRelatorioEntrega ent = new FiltroRelatorioEntrega();
            ent.ShowDialog();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargo car = new FrmCargo();
            car.ShowDialog();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaCli cli = new FrmConsultaCli();
            cli.ShowDialog();
        }

        private void funcionarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmConsultaFunc func = new FrmConsultaFunc();
            func.ShowDialog();
        }

        private void entregaToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            FrmConsultaEntre f = new FrmConsultaEntre();
            f.ShowDialog();
        }

        private void cargoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCargo ca = new FrmCargo();
            ca.ShowDialog();
        }

        private void veiculoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVeiculo ve = new FrmVeiculo();
            ve.ShowDialog();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstado es = new FrmEstado();
            es.ShowDialog();
        }



    }
}