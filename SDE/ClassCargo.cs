using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SDE
{
    class ClassCargo
    {
        conexao c = new conexao();

        public String cadastrarCargo(String estado)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO  tbCargo (descrCargo) VALUES ('" + estado + "')", c.con);

            c.conectar();
            int qtd = cmd.ExecuteNonQuery();
            if (qtd > 0)
                return ("Cargo cadastrado com sucesso.");
            else
                return ("Erro");
            c.desconectar();

        }


        public DataTable pesquisaAproximadaNome(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("select codCargo,descrCargo as Cargo  from tbCargo WHERE descrCargo  LIKE '" + pesquisar + "%' ", c.con);


            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable funcionario = new DataTable();
            da.Fill(funcionario);
            c.desconectar();
            return funcionario;
        }

        public DataTable preencherDataGrid()
        {
            SqlCommand cmd = new SqlCommand("select codCargo,descrCargo as Cargo from tbCargo", c.con);

            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public String excluirCargo(int cod)
        {
            SqlCommand cmd = new SqlCommand("delete from tbCargo where codCargo = " + cod + "", c.con);
            c.conectar();

            int qtd = cmd.ExecuteNonQuery();

            c.desconectar();

            if (qtd > 0)
                return ("Cargo excluido com sucesso.");
            else

                return ("Não foi possivel excluir o Cargo.");

        }
        public String alterareCargo(String estado, int cod)
        {

            // inicio codigo para alterar os dados do cliente 
            SqlCommand cmd2 = new SqlCommand("UPDATE tbCargo set descrCargo='" + estado + "' where codCargo=" + cod + "", c.con);
            c.conectar();
            int qtd3 = cmd2.ExecuteNonQuery();
            int codCli = Convert.ToInt32(cmd2.ExecuteScalar());
            c.desconectar();
            if (qtd3 > 0)
                return ("Cargo alterado com sucesso.");
            else
                return ("Erro na alteração do cargo!");


        }

        public int ConsultaCargo(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("Select count(descrCargo) from tbCargo WHERE descrCargo LIKE '%" + pesquisar + "%' ", c.con);
            c.conectar();
            int qtde = 0;
            qtde = Convert.ToInt32(cmd.ExecuteScalar());

            c.desconectar();
            return qtde;
        }
    }
}
