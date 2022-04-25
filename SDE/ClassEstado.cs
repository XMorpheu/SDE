using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SDE
{
    class ClassEstado
    {
         conexao c = new conexao();

        public String cadastrarEstado(String estado)
        {

            SqlCommand cmd = new SqlCommand("INSERT INTO  tbEstado (descrEstado) VALUES ('" + estado + "')", c.con);
            
        c.conectar();
             int qtd = cmd.ExecuteNonQuery();
             if(qtd>0)
                return("estado cadastrado com sucesso.");
            else
                return("Erro");   
           c.desconectar();
        
        }


         public DataTable pesquisaAproximadaNome(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("select  codEstado,descrEstado as Estado  from tbEstado WHERE descrEstado  LIKE '" + pesquisar + "%' ", c.con);
           

             c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable funcionario = new DataTable();
            da.Fill(funcionario);
            c.desconectar();
            return funcionario;
        }

          public DataTable preencherDataGrid()
        {
            SqlCommand cmd = new SqlCommand("select codEstado,descrEstado as Estado from tbEstado", c.con);
           
              c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

          public String excluirEstado(int cod)
          {
              SqlCommand cmd = new SqlCommand("delete from tbEstado where codEstado = " + cod + "", c.con);
              c.conectar();
                          
              int qtd= cmd.ExecuteNonQuery();

              c.desconectar();
              
              if (qtd> 0)
                  return ("Estado excluido com sucesso.");
              else
                 
              return ("Não foi possivel excluir o Estado.");

          }
          public String alterareEstado(String estado, int cod)
          {

              // inicio codigo para alterar os dados do cliente 
              SqlCommand cmd2 = new SqlCommand("UPDATE tbEstado set descrEstado='" + estado + "' where codEstado=" + cod + "", c.con);
              c.conectar();
              int qtd3 = cmd2.ExecuteNonQuery();
              int codCli = Convert.ToInt32(cmd2.ExecuteScalar());
              c.desconectar();
              if (qtd3 > 0)
                  return ("Estado alterado com sucesso.");
              else
                  return ("Erro na alteração do Estado!");


          }

          public int ConsultaEstado(string pesquisar)
          {
              SqlCommand cmd = new SqlCommand("Select count(descrEstado) from tbEstado WHERE descrEstado LIKE '%" + pesquisar + "%' ", c.con);
              c.conectar();
              int qtde = 0;
              qtde = Convert.ToInt32(cmd.ExecuteScalar());

              c.desconectar();
              return qtde;
          }



    }
    }
