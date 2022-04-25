using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace SDE
{
    class ClassEntrega
    {
        conexao c = new conexao();
       
        public String cadastrarEntrega(String rua, String bairro, String cep, String contato, int numero, int volume,
           String descrição, Double valor, String status, String horaida, String horavolta, DateTime dataEntrega,
            int numeroEntrega, int numeroNota , int codFuncionario, int codVeiculo, int codCliente, int codEstado, String bairroRet, String ruaRet, String cepRet,
            int numeroRet,String complementoRet,String contatoRet,String dataRet,int codEstadoRet)
                        
        {
            //salvando na tabela da entrega 
            SqlCommand cmd = new SqlCommand("INSERT INTO tbEntrega (rua,bairro,cep,contato,numero,volume,descricao,valor,statusEntrega,horaIda,horaVolta,dataEntrega,numeroEntrega,numeroNota,codFuncionario,codVeiculo,codCliente,codEstado)"+
             " VALUES ('" + rua + "','" + bairro + "','" + cep + "','" + contato + "'," + numero + "," + volume + ",'" + descrição + "','" + valor + "','" + status + "','" + horaida + "','"+horavolta+"','"+dataEntrega+"'," + numeroEntrega + ","+numeroNota+"," + codFuncionario + "," + codVeiculo + ","+codCliente+","+codEstado+")", c.con);
                  
            c.conectar();
            {
                int qtd = cmd.ExecuteNonQuery();
                SqlCommand cmd2 = new SqlCommand("SELECT MAX(codEntrega) FROM tbEntrega ", c.con);
                int codEntrega = Convert.ToInt32(cmd2.ExecuteScalar());
                
                //salvando na tabela de retirada
                SqlCommand cmd1 = new SqlCommand("INSERT INTO tbRetirada (bairroRetirada,ruaRetirada,cepRetirada,numeroRetirada,complementoRetirada,contatoRetirada,dataRetirada,codEstado,codEntrega)" +
             " VALUES ('" + bairroRet + "','" + ruaRet + "','" + cepRet + "'," + numeroRet + ",'" + complementoRet + "','" + contatoRet + "','" + dataRet + "'," + codEstado  + "," + codEntrega + ")", c.con);
                int qtd2 = cmd1.ExecuteNonQuery();

                

                c.desconectar();


                if ((qtd > 0)&(qtd2>0))
                    return ("Entrega cadastrado com sucesso.");
                else
                    return ("Erro no cadastro do Entrega!");

            }

         }

        // método para exbliur 

        public String excluirEntrega(int cod)
        {
            SqlCommand cmd = new SqlCommand("delete from tbRetirada where codEntrega = " + cod + "", c.con);
            SqlCommand cmd1 = new SqlCommand("delete from tbEntrega where codEntrega = " + cod + "", c.con);

            c.conectar();
            {
                int qtd = cmd.ExecuteNonQuery();
                int qtd1 = cmd1.ExecuteNonQuery();
                
                if ((qtd > 0) & (qtd1>0))
                    return ("Entrega excluido com sucesso.");
                else
                    return ("não foi possivel excluir o Entrega.");

            }
        }// fim da método


        // método paa alterar 
        public String AlterarEntrega (String rua, String bairro, String cep, String contato, int numero, int volume,
           String descrição, Double valor, String status, String horaida, String horavolta, DateTime dataRet,
            int numeroEntrega, int codFuncionario, int codVeiculo, int codCliente, int codEstado, String bairroRet, String ruaRet, String cepRet,
            int numeroRet, String complementoRet, String contatoRet, int codEstadoRet,int cod)
        {
                     
            SqlCommand cmd = new SqlCommand("UPDATE tbEntrega set rua='" + rua + "',bairro='" + bairro + "',cep= '" + cep + "'," +
           "contato='"+contato+"',numero=" + numero + ",volume=" + volume + ",descricao='" + descrição + "',valor='" + valor + "',statusEntrega='" + status + "'," +
            "horaIda='"+horaida+"',horavolta='"+horavolta+"',numeroEntrega="+numeroEntrega+",codFuncionario=" + codFuncionario + ", "+
            "codVeiculo= " + codVeiculo + ",codCliente="+codCliente+",codEstado="+codEstado+" where codEntrega=" + cod + "", c.con);

            

            SqlCommand cmd2 = new SqlCommand("UPDATE tbRetirada set bairroRetirada='" + bairroRet + "',ruaRetirada='" + ruaRet + "',cepRetirada= '" + cepRet + "'," +
           "numeroRetirada=" + numeroRet + ",complementoRetirada='" + complementoRet + "',contatoRetirada='" + contatoRet + "',dataRetirada='" + dataRet + "',codEstado=" + codEstado + "," +
             " where codEntrega=" + cod + "", c.con);

            c.conectar();
            {
                int qtd = cmd.ExecuteNonQuery();
                int qtd2 = cmd.ExecuteNonQuery();

                if ((qtd > 0)&(qtd2>0))
                    return ("Entrega Alterada com sucesso.");
                else
                    return ("não foi possivel Alterada o Entrega.");

            }

        }// fim do método Alterar 
         
        public String[] carregarVei()
        {
            
            SqlCommand cmd = new SqlCommand("select count (codVeiculo)from tbVeiculo", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] listaUf = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select modelo from tbveiculo", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                listaUf[i] = siglas["modelo"].ToString();
                i++;
            }

            c.desconectar();
            return listaUf;
        }

        public String[] carregarEstado()
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
        }

        public String[] carregarfunc()
        {

            SqlCommand cmd = new SqlCommand("select count (codFuncionario)from tbFuncionario", c.con);
            c.conectar();
            int qtde = Convert.ToInt32(cmd.ExecuteScalar());
            String[] lista = new String[qtde];

            SqlCommand cmd2 = new SqlCommand("select nome from tbFuncionario", c.con);

            var siglas = cmd2.ExecuteReader();

            int i = 0;
            while (siglas.Read())
            {
                lista[i] = siglas["nome"].ToString();
                i++;
            }

            c.desconectar();
            return lista;
        }


        public DataTable preencherDataGrid()
        {
            SqlCommand cmd = new SqlCommand("select e.codEntrega,e.numeroEntrega,e.numero,e.volume,e.valor,c.nome,c.cnpj,f.nome,v.modelo from tbEntrega e inner join tbCliente c on c.codCliente=e.codCliente inner join tbFuncionario f on f.codFuncionario = e.codFuncionario inner join tbVeiculo v on v.codVeiculo = e.codVeiculo ", c.con);
            // SqlCommand cmd = new SqlCommand("select c.codCliente,c.nome as Nome,c.cnpj as CNPJ,c.horaFunc as Data,c.contato as Contado,c.rua as Rua,c.bairro as Bairro,c.cep as CEP,c.numero as Numero,c.complemento as Complemento,u.descrEstado from tbCliente As c INNER JOIN tbEstado AS u ON c.codEstado=u.codEstado WHERE cnpj LIKE '%" + pesquisar + "%' ", c.con);

            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public DataTable pesquisacnpj(String pesquisa)
        {
            SqlCommand cmd = new SqlCommand("select e.codEntrega,e.numeroEntrega,e.numero,e.volume,e.valor,c.nome,c.cnpj,f.nome,v.modelo from tbEntrega e inner join tbCliente c on c.codCliente=e.codCliente inner join tbFuncionario f on f.codFuncionario = e.codFuncionario inner join tbVeiculo v on v.codVeiculo = e.codVeiculo  where c.cnpj like  '%" + pesquisa + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public DataTable pesquisanome(String pesquisa)
        {
            SqlCommand cmd = new SqlCommand("select e.codEntrega,e.numeroEntrega,e.numero,e.volume,e.valor,c.nome,c.cnpj,f.nome,v.modelo from tbEntrega e inner join tbCliente c on c.codCliente=e.codCliente inner join tbFuncionario f on f.codFuncionario = e.codFuncionario inner join tbVeiculo v on v.codVeiculo = e.codVeiculo  where c.nome like  '" + pesquisa + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }

        public DataTable pesquisanumeros(String pesquisa)
        {
            SqlCommand cmd = new SqlCommand("select e.codEntrega,e.numeroEntrega,e.numero,e.volume,e.valor,c.nome,c.cnpj,f.nome,v.modelo from tbEntrega e inner join tbCliente c on c.codCliente=e.codCliente inner join tbFuncionario f on f.codFuncionario = e.codFuncionario inner join tbVeiculo v on v.codVeiculo = e.codVeiculo  where e.numeroEntrega like  '%" + pesquisa + "%' ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }


     
     

        public DataTable Consulta(int pesquisa)
        {
            SqlCommand cmd = new SqlCommand("Select r.codRetirada,e.rua,e.bairro,e.cep,e.contato,e.numero,e.volume,e.descricao,e.valor,e.statusEntrega,e.horaIda,"+
                    "e.numeroEntrega,e.numeroNota,r.bairroRetirada,r.ruaRetirada,r.cepRetirada,r.numeroRetirada,"+
                    "r.complementoRetirada,r.dataRetirada,c.nome,c.cnpj,v.modelo,f.nome,es.descrEstado,r.codEstado,r.contatoRetirada,c.codCliente,e.horaVolta from tbRetirada r inner join tbEntrega e on e.codEntrega = r.codEntrega inner join " +
                    "tbCliente c on c.codCliente = e.codCliente inner join tbVeiculo v on v.codVeiculo = e.codVeiculo inner join tbFuncionario f on f.codFuncionario = e.codFuncionario "+
                   "inner join tbEstado es on es.codEstado = e.codEstado where e.codEntrega = " +pesquisa+" ", c.con);
            c.conectar();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable clientes = new DataTable();
            da.Fill(clientes);
            c.desconectar();
            return clientes;
        }


 






    }
}