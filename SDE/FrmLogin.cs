using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SDE
{
    public partial class FrmLogin : Form
    {
        int i = 3;
        public FrmLogin()
        {
            InitializeComponent();
            Thread t = new Thread(new ThreadStart(splashScreen));
            t.Start();
            Thread.Sleep(4000);
            t.Abort();

        }

        public void splashScreen()
        {
            Application.Run(new Splash());
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (txtusuario.Text == "admin" && txtsenha.Text == "123")
            {
                FrmPrincipal p = new FrmPrincipal();
                p.ShowDialog();
                this.Close();
                this.Hide();
            }
            
          
            else{

                if (i != 0)
                {
                    i = i - 1;
                   
                    if (i == 0)
                    {
                        Application.Exit();
                    }
                    String menssagem = "Login ou senha incorretos. " + "\n" + "Você tem mais " + i + " tentativas";
                    String titulo = "SDE";
                    MessageBox.Show(menssagem, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1);
                

          


                                   
                }
                
                  
                
            }
        
            }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        }
    }

