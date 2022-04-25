using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Text.RegularExpressions;


namespace SDE
{
    class validacao
    {
        public static bool ValidaCNPJ(string vrCNPJ)
        {
            string CNPJ = vrCNPJ.Replace(",", "");
            CNPJ = CNPJ.Replace("/", "");
            CNPJ = CNPJ.Replace("-", "");
            int[] digitos, soma, resultado;
            int nrDig; string ftmt;
            bool[] CNPJOk;
            ftmt = "6543298765432";
            digitos = new int[14];
            soma = new int[2];
            soma[0] = 0; soma[1] = 0;
            resultado = new int[2];
            resultado[0] = 0; resultado[1] = 0;
            CNPJOk = new bool[2];
            CNPJOk[0] = false; CNPJOk[1] = false;


            try
            {

                for (nrDig = 0; nrDig < 14; nrDig++)
                {

                    digitos[nrDig] = int.Parse(CNPJ.Substring(nrDig, 1));
                    if (nrDig <= 11) soma[0] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig + 1, 1)));
                    if (nrDig <= 12) soma[1] += (digitos[nrDig] * int.Parse(ftmt.Substring(nrDig, 1)));
                }
                for (nrDig = 0; nrDig < 2; nrDig++)
                {
                    resultado[nrDig] = (soma[nrDig] % 11);
                    if ((resultado[nrDig] == 0) || (resultado[nrDig] == 1)) CNPJOk[nrDig] = (digitos[12 + nrDig] == 0);
                    
                    else CNPJOk[nrDig] = (digitos[12 + nrDig] == (11 - resultado[nrDig]));


                }
                return true;
            }
            catch
            {
                return false;
            }

        }



        public static Boolean CPF(String cpf)
        {
            int[] vetCpf = new int[11];
            int digito1, digito2, contador, soma1 = 0, soma2 = 0;

            cpf = cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2);



            for (int i = 0; i < 11; i++)
            {
                vetCpf[i] = Convert.ToInt32(cpf.Substring(i, 1));
            }

            //Cálculo do 1º Dígito
            contador = 10;

            for (int i = 0; i < 9; i++)
            {
                soma1 = soma1 + (vetCpf[i] * contador);
                contador--;

            }

            digito1 = soma1 % 11;
            if (digito1 < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - digito1;
            }

            //Cálculo do 2º Dígito

            contador = 11;
            for (int i = 0; i < 10; i++)
            {
                soma2 = soma2 + (vetCpf[i] * contador);
                contador--;
            }
            digito2 = soma2 % 11;
            if (digito2 < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - digito2;
            }




            if ((digito1 == vetCpf[9]) && (digito2 == vetCpf[10]))
            {
                if (cpf == "11111111111" | cpf == "22222222222" | cpf == "33333333333" | cpf == "44444444444" | cpf == "55555555555" | cpf == "66666666666" | cpf == "77777777777" | cpf == "88888888888" | cpf == "99999999999" | cpf == "00000000000")
                {
                    return false;
                }
                else
                {
                    return true;
                }



            }

            else
            {
                return (false);

            }

        }

        public static bool ValidaNumero(string numero)
        {
            Regex rx = new Regex(@"^\d+$");
            return rx.IsMatch(numero);
        }


        public static bool ValidaNome(string nome)
        {

            string nome2 = @"[A-z][ ][A-z]";

            Match match = Regex.Match(nome, nome2);


            if (match.Success)
            {

                return true;

            }

            else
            {

                return false;

            }

        }

    }
}
