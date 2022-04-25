using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SDE
{
    class conexao
    {
        public SqlConnection con = new SqlConnection(@"Server=ROBSON-PC\SQLEXPRESS;Database=bdTccProjeto; integrated Security=SSPI;");

        public String conectar()
        {
            try
            {
                con.Open();
                return ("Conexão realizada com sucesso!");
            }


            catch (Exception e)
            {
                return (e.ToString());
            }

        }

        public String desconectar()
        {
            con.Close();
            return ("Conexão encerrada com sucesso!");
        }
    }
}

    

