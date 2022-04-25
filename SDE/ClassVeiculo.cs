using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
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
    class ClassVeiculo
    {

        String menssagem = "";
        String titulo = "SDE";
        conexao c = new conexao();

        public String cadastrarVeiculo(String descrCor, String descrMarca, String descrModelo, String placa, String rodizio, String chassi)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbVeiculo (cor,marca,modelo,placa,rodizio,chassi) VALUES ('" + descrCor + "','" + descrMarca + "','" + descrModelo + "','" + placa + "','" + rodizio + "','" + chassi + "')", c.con);

            c.conectar();
            {
                int qtd = cmd.ExecuteNonQuery();


                if ((qtd > 0))
                {
                    menssagem = "Veículo Cadastrado Com Sucesso";

                    MessageBox.Show(menssagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return ("Pixels Bytes");

                }
                else
                {

                    menssagem = "Erro no  Cadastrado De Veículo";

                    MessageBox.Show(menssagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return ("Pixels Bytes");



                }
            }
        }

        public String excluirVeiculo(int cod)
        {
            SqlCommand cmd = new SqlCommand("delete from tbVeiculo where codveiculo = " + cod + "", c.con);
            c.conectar();
           
                int qtd = cmd.ExecuteNonQuery();
                cod = Convert.ToInt32(cmd.ExecuteScalar());


                if (qtd > 0)
                {

                    menssagem = "Veículo Excluido Com Sucesso";

                    MessageBox.Show(menssagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return ("Pixels Bytes");

                }else{
                    menssagem = "Erro Na exclusão de veículo";

                    MessageBox.Show(menssagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return ("Pixels Bytes");
                    }
        }

        public DataTable preencherDataGrid()
        {
            SqlCommand cmd = new SqlCommand("select codVeiculo,modelo as Modelo,placa as Placa,marca as Marca,cor as Cor,rodizio as Rodizio, chassi as Chassi from tbVeiculo", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public DataTable pesquisaExataPlaca(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("select codVeiculo,modelo as Modelo,placa as Placa,marca as Marca,cor as Cor,rodizio as Rodizio, chassi as Chassi from tbVeiculo WHERE placa LIKE '%" + pesquisar + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public int Consultarplaca(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("Select count(placa) from tbVeiculo WHERE placa LIKE '%" + pesquisar + "%' ", c.con);
            c.conectar();
            int qtde = 0;
            qtde = Convert.ToInt32(cmd.ExecuteScalar());

            c.desconectar();
            return qtde;
        }

        public String alterarveiculo(String descrCor, String descrMarca, String descrModelo, String placa, String rodizio, String chassi, int cod)
        {

            // inicio codigo para alterar os dados do cliente 
            SqlCommand cmd2 = new SqlCommand("UPDATE tbVeiculo set cor='" + descrCor + "',Marca='" + descrMarca + "',Modelo='" + descrModelo + "',placa='" + placa + "',rodizio='" + rodizio + "',chassi='" + chassi + "' where codVeiculo=" + cod + "", c.con);
            c.conectar();
            int qtd3 = cmd2.ExecuteNonQuery();
            int codCli = Convert.ToInt32(cmd2.ExecuteScalar());

            c.desconectar();



            if (qtd3 > 0)
            {
                menssagem = "Veiculo alterado com sucesso com sucesso.";

                MessageBox.Show(menssagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return ("Pixels Bytes");
            }
            else
            {
                menssagem="Erro na alteração do Veiculo";
                MessageBox.Show(menssagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return ("Pixels Bytes");
            }

        }

        public String[] carregarCor()
        {
            SqlCommand cmd = new SqlCommand("select count (codCor)from tbCor", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] listaUf = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select descrCor from tbCor", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                listaUf[i] = siglas["descrCor"].ToString();
                i++;
            }

            c.desconectar();
            return listaUf;
        } // FIM 

        public String[] carregarMarca()
        {
            SqlCommand cmd = new SqlCommand("select count (codMarca)from tbMarca", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] listaUf = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select descrMarca from tbMarca", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                listaUf[i] = siglas["descrMarca"].ToString();
                i++;
            }

            c.desconectar();
            return listaUf;
        } // FIM 



    }
}




