using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SDE
{
    class ClassFuncionario
    {
        conexao c = new conexao();

        public String cadastrarFuncionario(String nomefunc, String cnh, String dtnasc, String ruafunc, String bairrofunc,
            String cepfunc, String numEndfunc, String compfunc, String descfuncao, String cpf, String cargo,int codEstado, int numVetor, String[] numFoneCli)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO tbFuncionario (nome,cnh,dtnasc,rua,bairro,cep,numero,complemento,descrFuncao,cpf,cargo,codEstado) VALUES ('" + nomefunc + "','" + cnh + "','" + dtnasc + "','" + ruafunc + "','" + bairrofunc + "','" + cepfunc + "','" + numEndfunc + "','" + compfunc + "','" + descfuncao + "','" + cpf + "','" + cargo + "',"+codEstado+")", c.con);
            c.conectar();
            {


                int qtd = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("SELECT MAX(codFuncionario) FROM tbFuncionario ", c.con);
                int codfunc = Convert.ToInt32(cmd2.ExecuteScalar());
                int qtd2 = 0;

                for (int i = 0; i < numVetor; i++)
                {
                    SqlCommand cmd3 = new SqlCommand("INSERT INTO tbTelFuncionario(telFuncionario,codFuncionario) VALUES('" + numFoneCli[i] + "','" + codfunc + "')", c.con);
                    qtd2 = cmd3.ExecuteNonQuery();

                }

                c.desconectar();



                if ((qtd > 0) && (qtd2 > 0))
                    return ("Cliente cadastrado com sucesso.");
                else
                    return ("Erro no cadastro do Cliente!");


            }





        }

        public String excluirCliente(int cod)
        {
            SqlCommand cmd = new SqlCommand("delete from tbTelfuncionario where codFuncionario = " + cod + "", c.con);
            c.conectar();
            {
                int qtd = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("delete from tbFuncionario where codFuncionario = " + cod + "", c.con);

                cod = Convert.ToInt32(cmd2.ExecuteScalar());

                int qtd2 = cmd2.ExecuteNonQuery();

                if (qtd2 > 0)
                    return ("não foi possivel excluir o Cliente.");
                else
                    return ("Cliente excluido com sucesso.");
            }


        }
    














        public DataTable preencherDataGrid()
        {
            SqlCommand cmd = new SqlCommand("select codFuncionario,c.nome as Nome,c.cnh as CNH,c.dtnasc as DataNascimento,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento AS Complemento,c.descrFuncao as Função,c.cpf,c.cargo,u.descrEstado  from tbFuncionario As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado", c.con);
           // SqlCommand cmd = new SqlCommand("select c.codCliente,c.nome as Nome,c.cnpj as CNPJ,c.horaFunc as Data,c.contato as Contado,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento as Complemento,u.descrEstado from tbCliente As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado  ", c.con);
           
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }


        public DataTable pesquisacpf(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("select codFuncionario,c.nome as Nome,c.cnh as CNH,c.dtnasc as DataNascimento,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento AS Complemento,c.descrFuncao as Função,c.cpf,c.cargo,u.descrEstado  from tbFuncionario As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado WHERE cpf LIKE '%" + pesquisar + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public DataTable pesquisaaproximada(string pesquisa)
        {
            SqlCommand cmd = new SqlCommand("select codFuncionario,c.nome as Nome,c.cnh as CNH,c.dtnasc as DataNascimento,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento AS Complemento,c.descrFuncao as Função,c.cpf,c.cargo,u.descrEstado  from tbFuncionario As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado WHERE c.nome LIKE '" + pesquisa + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }



        public String alterarFuncionrio(String nomefunc, String cnh, String dtnasc,
          String ruafunc, String bairrofunc, String cepfunc, String numEndfunc, String compfunc,
          String descfuncao, String cpf, String cargo,int codEstado, int numVetor, String[] numFoneCli, int cod)
        {
            // codigo para deletar os numeros de telefone 
            SqlCommand cmd = new SqlCommand("delete from tbTelfuncionario where codFuncionario = " + cod + "", c.con);
            c.conectar();
            int qtd = cmd.ExecuteNonQuery();
            // fim do codigo para deletar 

            // inicio codigo para alterar os dados do cliente 
            SqlCommand cmd2 = new SqlCommand("UPDATE tbFuncionario set nome='" + nomefunc + "',cnh='" + cnh + "',dtnasc= '" + dtnasc + "',rua='" + ruafunc + "',bairro='" + bairrofunc + "',cep='" + cepfunc + "',numero='" + numEndfunc + "',complemento='" + compfunc + "',descrFuncao='" + descfuncao + "',cpf='" + cpf + "',cargo='" + cargo + "',codEstado="+codEstado+" where codFuncionario=" + cod + "", c.con);
            int qtd3 = cmd2.ExecuteNonQuery();
            int codCli = Convert.ToInt32(cmd2.ExecuteScalar());
            // fim da alteração dos dados do  cliente 


            //codigo para salvar os numeros de telefone!!    
            int qtd2 = 0;

            for (int i = 0; i < numVetor; i++)
            {
                SqlCommand cmd3 = new SqlCommand("INSERT INTO tbTelfuncionario(telFuncionario,codFuncionario) VALUES('" + numFoneCli[i] + "','" + cod + "')", c.con);
                qtd2 = cmd3.ExecuteNonQuery();

            }
            // fim do codigo!
            c.desconectar();



            if (qtd3>0)
                return ("Funcionario alterado com sucesso com sucesso.");
            else
                return ("Erro no alteração do Funcionario!");


        }

        // pesquisa para verificar se a um cadastro com AQUELE CPF
        public int ConsultarCpf(string pesquisar)
        {
            SqlCommand cmd = new SqlCommand("Select count(codFuncionario) from tbFuncionario WHERE cpf LIKE '%" + pesquisar + "%' ", c.con);
            int qtde = 0;            
            c.conectar();            

            qtde = Convert.ToInt32(cmd.ExecuteScalar());

            c.desconectar();
            return qtde;
        } // FIM DA VERIFICAÇÃO

        // METODO PARA PREENCHER A COMBOBOX
        public String[] carregarUf()
        {
            SqlCommand cmd = new SqlCommand("select count (codEstado)from tbEstado", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
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
        } // FIM 


        public String[] carregarCargo()
        {
            SqlCommand cmd = new SqlCommand("select count (codCargo)from tbCargo", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] listaUf = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select descrCargo from tbCargo", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                listaUf[i] = siglas["descrCargo"].ToString();
                i++;
            }

            c.desconectar();
            return listaUf;
        } // FIM 





      
    }
}
