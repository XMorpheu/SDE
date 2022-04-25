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
    public partial class FrmConsultaEntre : Form
    {
        ClassEntrega e = new ClassEntrega();
        string codigoId;

        public FrmConsultaEntre()
        {
            InitializeComponent();
            dataGridView1.DataSource = e.preencherDataGrid();
            this.dataGridView1.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            this.dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
         
        }

        private void FrmConsultaEntre_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int linhaAtual = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
            codigoId = row.Cells["codEntrega"].Value.ToString();         
        
             
        }

        private void txtalterar_Click(object sender, EventArgs e)
        {
            FrmEntrega formDestino = new FrmEntrega();
            formDestino.Propriedade = codigoId;
            formDestino.Show();
        }

        private void txtpsqnome_TextChanged(object sender, EventArgs e)
        {
            ClassEntrega ex = new ClassEntrega();
            dataGridView1.DataSource = ex.pesquisanome(txtpsqnome.Text);
            
        }

        private void cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb.Text == "CNPJ")
            {
                txtpsqcnpj.Visible = true;
                txtpsqnome.Visible = false;
                txtpsqpedido.Visible = false;
                
            }

            if (cmb.Text == "NOME")
            {
                txtpsqcnpj.Visible = false;
                txtpsqnome.Visible = true;
                txtpsqpedido.Visible = false;
                
                
            }

            if (cmb.Text == "PEDIDO")
            {
                txtpsqcnpj.Visible = false;
                txtpsqnome.Visible = false;
                txtpsqpedido.Visible = true;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cmb.Text == "CNPJ")
            {

                ClassEntrega exc = new ClassEntrega();
                dataGridView1.DataSource = exc.pesquisacnpj(txtpsqcnpj.Text);
               
            }


            if (cmb.Text == "PEDIDO")
            {
                ClassEntrega exb = new ClassEntrega();
                dataGridView1.DataSource = exb.pesquisanumeros(txtpsqpedido.Text);

            }

          

           
        }
    }
}
