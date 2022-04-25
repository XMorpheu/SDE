using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SDE
{
    class Backup
    {
        conexao c = new conexao();
        public String backupp()
        {
            System.Data.SqlClient.SqlCommand cmdBackup = new System.Data.SqlClient.SqlCommand();
            SqlConnection con = new SqlConnection(@"Server=ROBSON-PC\SQLEXPRESS;Database=bdTccProjeto; integrated Security=SSPI;");
            cmdBackup.Connection = con;

         
            string NomedoSistema = "SDE";
            try
            {

                cmdBackup.CommandText = " BACKUP DATABASE bdTccProjeto to Disk = 'D:" + NomedoSistema + "_" + DateTime.Today.Day.ToString() + "_" + DateTime.Today.Month.ToString() + "_" + DateTime.Today.Year.ToString() + ".bak'";
               
                con.Open();
                cmdBackup.ExecuteNonQuery();
                con.Close();
                return ("Backup realizada com sucesso!");
            }


            catch (Exception e)
            {
                c.desconectar();
                return (e.ToString());
            }
        }
        public String restautar(String lblCaminho)
        {
                                try
                    {

                    System.Data.SqlClient.SqlCommand cmdBackup = new System.Data.SqlClient.SqlCommand();

                    SqlConnection conn = new SqlConnection(@"Server=ROBSON-PC\SQLEXPRESS; Database=bdTccProjeto; Initial Catalog=master; integrated Security=SSPI;");
                    string NomedoBanco = "bdTccProjeto";

                    cmdBackup.Connection = conn;

                    cmdBackup.CommandText = "alter database bdTccProjeto set single_user with rollback immediate";// Coloque o nome do seu banco de dados
                    conn.Open();
                    cmdBackup.ExecuteNonQuery();
                    conn.Close();


                    cmdBackup.CommandText = "USE MASTER RESTORE DATABASE [bdTccProjeto] FROM DISK = '" + lblCaminho + "'";//Coloque o nome do seu banco
                    conn.Open();
                    cmdBackup.ExecuteNonQuery();
                    conn.Close();
                                                      
                                    

                  /* cmdBackup.CommandText = string.Format("RESTORE DATABASE bdTccProjeto FROM DISK = '" + NomedoBanco + "''" + lblCaminho + "'");
                    cmdBackup.CommandText = ("RESTORE DATABASE bdTccProjeto FROM DISK = '" + lblCaminho + "' ");
                  //  cmdBackup.CommandText = (" RESTORE FILELISTONLY FROM DISK = '" + lblCaminho + "'");
                    conn.Open();
                    cmdBackup.ExecuteNonQuery();
                    conn.Close();
                     */

                    conexao c = new conexao();
                    c.desconectar();
                    return ("Restauração do Banco de Dados realizado com sucesso");
                    }
                     catch (Exception e)
                    {
                        return (e.ToString());
                         


                    }
                    }
                   
        }
    
    
    
    
    
    
    }
