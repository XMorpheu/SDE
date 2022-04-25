using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SDE
{
    class ClassCliente
    {
        conexao c = new conexao();
        // método para salvar um novo cliente 
        public String cadastrarCliente(String nomeCli, String cnpjCli, String contatoCli, String ruaCli, String bairroCli,
            String cepCli, String numEndCli, String compCli,int codEstado,int numVetor, String[] numFoneCli)
        {
            // inserir imformações na tbClienete 
            SqlCommand cmd = new SqlCommand("INSERT INTO tbCliente (nome,cnpj,contato,rua,bairro,cep,numero,complemento,codEstado) VALUES ('" + nomeCli + "','" + cnpjCli + "','" + contatoCli + "','" + ruaCli + "','" + bairroCli + "','" + cepCli + "' ,'" + numEndCli + "','" + compCli + "',"+codEstado+")", c.con);
            c.conectar();
            {

                // pegando o o cod do ultimo 
                int qtd = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("SELECT MAX(codCliente) FROM tbCliente ", c.con);
                int codCli = Convert.ToInt32(cmd2.ExecuteScalar());
                int qtd2 = 0;

                for (int i = 0; i < numVetor; i++)
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tbTelCliente(telCliente,codCliente) VALUES('" + numFoneCli[i] + "','" + codCli + "')", c.con);
                    qtd2 = cmd3.ExecuteNonQuery();

                }

                c.desconectar();



                if ((qtd > 0) && (qtd2 > 0))
                    return ("Cliente cadastrado com sucesso.");
                else
                    return ("Erro no cadastro do Cliente!");


            } // fim do método

        }

        // método de exclusão de cliente 
        public String excluirCliente(int cod)

        {
            SqlCommand cmd = new SqlCommand("delete from tbTelCliente where codCliente = " + cod + "", c.con);
            c.conectar();
            {
            int qtd = cmd.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand("delete from tbCliente where codCliente = " + cod + "", c.con);
            
                cod = Convert.ToInt32(cmd2.ExecuteScalar());
               
                int qtd2 = cmd2.ExecuteNonQuery();

                if (qtd2 > 0)
                    return ("não foi possivel excluir o Cliente.");
                else
                    return ("Cliente excluido com sucesso.");
                   
            }


        }// final do codigo de eclusão 
    
        public String alterarCliente(String nomeCli, String cnpjCli,String contatoCli, String ruaCli, String bairroCli,
          String cepCli, String numEndCli, String compCli,int codEstado ,int numVetor, String[] numFoneCli,int cod)
        {
           // codigo para deletar os numeros de telefone 
            SqlCommand cmd = new SqlCommand("delete from tbTelCliente where codCliente = " + cod + "", c.con);
            c.conectar();
              int qtd = cmd.ExecuteNonQuery();
              // fim do codigo para deletar 

            // inicio codigo para alterar os dados do cliente 
                SqlCommand cmd2 = new SqlCommand("UPDATE tbCliente set nome='" + nomeCli + "',cnpj='" + cnpjCli + "',contato='" + contatoCli + "',rua='" + ruaCli + "',bairro='" + bairroCli + "',cep='" + cepCli + "',numero='" + numEndCli + "',complemento='" + compCli + "',codEstado="+ codEstado + " where codCliente=" + cod + "", c.con);
                int qtd3 = cmd2.ExecuteNonQuery();
                int codCli = Convert.ToInt32(cmd2.ExecuteScalar());
               // fim da alteração dos dados do  cliente 
            
            
            //codigo para salvar os numeros de telefone!!    
            int qtd2 = 0;
             
                for (int i = 0; i < numVetor; i++)    
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tbTelCliente(telcliente,codCliente) VALUES('" + numFoneCli[i] + "','" + cod + "')", c.con);
                    qtd2 = cmd3.ExecuteNonQuery();

                }
            // fim do codigo!
                c.desconectar();



                if ((qtd > 0) && (qtd2 > 0))
                    return ("Cliente alterado com sucesso com sucesso.");
                    
                else
                    return ("Erro no cadastro do Cliente!");


            }

        

        // preencher datagrid com todos os dados que existe no banco 
        public DataTable preencherDataGrid()
        {
            SqlCommand cmd = new SqlCommand("select c.codCliente,c.nome as Nome,c.cnpj as CNPJ,c.contato as Contado,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento as Complemento,u.descrEstado from tbCliente As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado", c.con);
           
           
            
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }
        // final do codigo 

        // preenchemento do datagrid após a pesquisa por cnpj 
        public DataTable pesquisaExatacnpj(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("select c.codCliente,c.nome as Nome,c.cnpj as CNPJ,c.contato as Contado,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento as Complemento,u.descrEstado from tbCliente As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado WHERE cnpj LIKE '%" + pesquisar + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }
        // fim 

        public DataTable pesquisaaproximada(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("select c.codCliente,c.nome as Nome,c.cnpj as CNPJ,c.contato as Contado,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento as Complemento,u.descrEstado from tbCliente As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado WHERE nome LIKE '" + pesquisar + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }



        public int Consultarcnpj(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("Select count(cnpj) from tbCliente WHERE cnpj LIKE '%" + pesquisar + "%' ", c.con);
            c.conectar();
            int qtde = 0;
            qtde = Convert.ToInt32(cmd.ExecuteScalar());

            c.desconectar();
            return qtde;
        }

        public String[] carregarUf()
        {
            SqlCommand cm = new SqlCommand("select count (codEstado)from tbEstado", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cm.ExecuteScalar());
            String[] listaUf = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select descrEstado from tbEstado", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                listaUf[i] = siglas["descrEstado"].ToString();
                i++;
            }

            c.desconectar();
            return listaUf;
        }


    }
}
