using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscrevendoNoCelular
{
    public class ConverteMenssagem
    {

        private Dictionary<string, string> DicionarioLetras;

        public string AddDicionarioLetras()
        {
            DicionarioLetras = new Dictionary<string, string>();

            DicionarioLetras.Add("A", "2");
            DicionarioLetras.Add("B", "2");
            DicionarioLetras.Add("C", "2");

            DicionarioLetras.Add("D", "3");
            DicionarioLetras.Add("E", "3");
            DicionarioLetras.Add("F", "3");

            DicionarioLetras.Add("G", "4");
            DicionarioLetras.Add("H", "4");
            DicionarioLetras.Add("I", "4");

            DicionarioLetras.Add("J", "5");
            DicionarioLetras.Add("K", "5");
            DicionarioLetras.Add("L", "5");

            DicionarioLetras.Add("M", "6");
            DicionarioLetras.Add("N", "6");
            DicionarioLetras.Add("O", "6");

            DicionarioLetras.Add("P", "7");
            DicionarioLetras.Add("Q", "7");
            DicionarioLetras.Add("R", "7");
            DicionarioLetras.Add("S", "7");

            DicionarioLetras.Add("T", "8");
            DicionarioLetras.Add("U", "8");
            DicionarioLetras.Add("V", "8");

            DicionarioLetras.Add("W", "9");
            DicionarioLetras.Add("X", "9");
            DicionarioLetras.Add("Y", "9");
            DicionarioLetras.Add("Z", "9");

            DicionarioLetras.Add(" ", "0");


            return "";

        }
        public string RetornaSeparador(string separador)
        {
            if (separador == "A")
            {
                return separador = DicionarioLetras["A"];
            }
            else if (separador == "B")
            {
                return separador = DicionarioLetras["B"];
            }
            else if (separador == "C")
            {
                return separador = DicionarioLetras["C"];
            }
            else if (separador == "D")
            {
                return separador = DicionarioLetras["D"];
            }
            else if (separador == "E")
            {
                return separador = DicionarioLetras["E"];
            }
            else if (separador == "F")
            {
                return separador = DicionarioLetras["F"];
            }
            else if (separador == "G")
            {
                return separador = DicionarioLetras["G"];
            }
            else if (separador == "H")
            {
                return separador = DicionarioLetras["H"];
            }
            else if (separador == "I")
            {
                return separador = DicionarioLetras["I"];
            }
            else if (separador == "J")
            {
                return separador = DicionarioLetras["J"];
            }
            else if (separador == "K")
            {
                return separador = DicionarioLetras["K"];
            }
            else if (separador == "L")
            {
                return separador = DicionarioLetras["L"];
            }
            else if (separador == "M")
            {
                return separador = DicionarioLetras["M"];
            }
            else if (separador == "N")
            {
                return separador = DicionarioLetras["N"];
            }
            else if (separador == "O")
            {
                return separador = DicionarioLetras["O"];
            }
            else if (separador == "P")
            {
                return separador = DicionarioLetras["P"];
            }
            else if (separador == "Q")
            {
                return separador = DicionarioLetras["Q"];
            }
            else if (separador == "R")
            {
                return separador = DicionarioLetras["R"];
            }
            else if (separador == "S")
            {
                return separador = DicionarioLetras["S"];
            }
            else if (separador == "T")
            {
                return separador = DicionarioLetras["T"];
            }
            else if (separador == "U")
            {
                return separador = DicionarioLetras["U"];
            }
            else if (separador == "V")
            {
                return separador = DicionarioLetras["V"];
            }
            else if (separador == "W")
            {
                return separador = DicionarioLetras["W"];
            }
            else if (separador == "X")
            {
                return separador = DicionarioLetras["X"];
            }
            else if (separador == "Y")
            {
                return separador = DicionarioLetras["Y"];
            }
            else if (separador == "Z")
            {
                return separador = DicionarioLetras["Z"];
            }
            if (separador == " ")
            {
                return separador = DicionarioLetras[" "];
            }
  
            return separador;
        }
        public string converterMensagem(string mensagem)
        {

            int ultimaLetra = mensagem.Length - 2;
            string resultadoConsulta = String.Empty;
            string resultadoFinal = String.Empty;
            string separador = String.Empty;
            string resultadoConsultaIfem = String.Empty;
            AddDicionarioLetras();


            if (mensagem.Length > 255)
            {
                return resultadoFinal = "Limite inválido";
            }


            for (int i = 0; i < mensagem.Length; i++)
            {

                if (i <= mensagem.Length - 1)
                {
                    resultadoConsulta = mensagem.Substring(i, 1);
                }

                if (i <= ultimaLetra)
                {

                    separador = mensagem.Substring(i + 1, 1);
                    resultadoConsultaIfem = RetornaSeparador(separador);
                }


                if (resultadoConsulta == "A")
                {
                    resultadoFinal += DicionarioLetras["A"];
                    resultadoConsulta = DicionarioLetras["A"];
                }
                else if (resultadoConsulta == "B")
                {
                    resultadoFinal += DicionarioLetras["B"] + DicionarioLetras["B"];
                    resultadoConsulta = DicionarioLetras["B"];
                }
                else if (resultadoConsulta == "C")
                {
                    resultadoFinal += DicionarioLetras["C"] + DicionarioLetras["C"] + DicionarioLetras["C"];
                    resultadoConsulta = DicionarioLetras["C"];
                }

                if (resultadoConsulta == "D")
                {
                    resultadoFinal += DicionarioLetras["D"];
                    resultadoConsulta = DicionarioLetras["D"];
                }
                else if (resultadoConsulta == "E")
                {
                    resultadoFinal += DicionarioLetras["E"] + DicionarioLetras["E"];
                    resultadoConsulta = DicionarioLetras["E"];
                }
                else if (resultadoConsulta == "F")
                {
                    resultadoFinal += DicionarioLetras["F"] + DicionarioLetras["F"] + DicionarioLetras["F"];
                    resultadoConsulta = DicionarioLetras["F"];
                }

                if (resultadoConsulta == "G")
                {
                    resultadoFinal += DicionarioLetras["G"];
                    resultadoConsulta = DicionarioLetras["G"];
                }
                else if (resultadoConsulta == "H")
                {
                    resultadoFinal += DicionarioLetras["H"] + DicionarioLetras["H"];
                    resultadoConsulta = DicionarioLetras["H"];
                }
                else if (resultadoConsulta == "I")
                {
                    resultadoFinal += DicionarioLetras["I"] + DicionarioLetras["I"] + DicionarioLetras["I"];
                    resultadoConsulta = DicionarioLetras["I"];
                }

                if (resultadoConsulta == "J")
                {
                    resultadoFinal += DicionarioLetras["J"];
                    resultadoConsulta = DicionarioLetras["J"];
                }
                else if (resultadoConsulta == "K")
                {
                    resultadoFinal += DicionarioLetras["K"] + DicionarioLetras["K"];
                    resultadoConsulta = DicionarioLetras["K"];
                }
                else if (resultadoConsulta == "L")
                {
                    resultadoFinal += DicionarioLetras["L"] + DicionarioLetras["L"] + DicionarioLetras["L"];
                    resultadoConsulta = DicionarioLetras["L"];
                }

                if (resultadoConsulta == "M")
                {
                    resultadoFinal += DicionarioLetras["M"];
                    resultadoConsulta = DicionarioLetras["M"];
                }
                else if (resultadoConsulta == "N")
                {
                    resultadoFinal += DicionarioLetras["N"] + DicionarioLetras["N"];
                    resultadoConsulta = DicionarioLetras["N"];
                }
                else if (resultadoConsulta == "O")
                {
                    resultadoFinal += DicionarioLetras["O"] + DicionarioLetras["O"] + DicionarioLetras["O"];
                    resultadoConsulta = DicionarioLetras["O"];
                }

                if (resultadoConsulta == "P")
                {
                    resultadoFinal += DicionarioLetras["P"];
                    resultadoConsulta = DicionarioLetras["P"];
                }
                else if (resultadoConsulta == "Q")
                {
                    resultadoFinal += DicionarioLetras["Q"] + DicionarioLetras["Q"];
                    resultadoConsulta = DicionarioLetras["Q"];
                }
                else if (resultadoConsulta == "R")
                {
                    resultadoFinal += DicionarioLetras["R"] + DicionarioLetras["R"] + DicionarioLetras["R"];
                    resultadoConsulta = DicionarioLetras["R"];
                }
                else if (resultadoConsulta == "S")
                {
                    resultadoFinal += DicionarioLetras["S"] + DicionarioLetras["S"] + DicionarioLetras["S"] + DicionarioLetras["S"];
                    resultadoConsulta = DicionarioLetras["S"];
                }
                if (resultadoConsulta == "T")
                {
                    resultadoFinal += DicionarioLetras["T"];
                    resultadoConsulta = DicionarioLetras["T"];
                }
                else if (resultadoConsulta == "U")
                {
                    resultadoFinal += DicionarioLetras["U"] + DicionarioLetras["U"];
                    resultadoConsulta = DicionarioLetras["U"];
                }
                else if (resultadoConsulta == "V")
                {
                    resultadoFinal += DicionarioLetras["V"] + DicionarioLetras["V"] + DicionarioLetras["V"];
                    resultadoConsulta = DicionarioLetras["V"];
                }
                if (resultadoConsulta == "W")
                {
                    resultadoFinal += DicionarioLetras["W"];
                    resultadoConsulta = DicionarioLetras["W"];
                }
                else if (resultadoConsulta == "X")
                {
                    resultadoFinal += DicionarioLetras["X"] + DicionarioLetras["X"];
                    resultadoConsulta = DicionarioLetras["X"];
                }
                else if (resultadoConsulta == "Y")
                {
                    resultadoFinal += DicionarioLetras["Y"] + DicionarioLetras["Y"] + DicionarioLetras["Y"];
                    resultadoConsulta = DicionarioLetras["Y"];
                }
                else if (resultadoConsulta == "Z")
                {
                    resultadoFinal += DicionarioLetras["Z"] + DicionarioLetras["Z"] + DicionarioLetras["Z"] + DicionarioLetras["Z"];
                    resultadoConsulta = DicionarioLetras["Z"];
                }

                if (resultadoConsulta == " ")
                {
                    resultadoFinal += DicionarioLetras[" "];
                    resultadoConsulta = DicionarioLetras[" "];
                }

                if (resultadoConsultaIfem == resultadoConsulta)
                {

                    resultadoFinal += "_";
                }

                resultadoConsultaIfem = String.Empty;
            }

            return resultadoFinal;
        }
    }
}

