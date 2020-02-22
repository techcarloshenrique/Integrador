using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Integrador
{
    class Arquivo
    {

        Gravar gravar = new Gravar();
        public class Gravar {

            public Boolean gerarCepPorEstado()
            {

                String[] uf = new String[] { "CE", "RN", "PI", "AL", "PE" };

                System.IO.StreamReader sr = null;
                StreamWriter valor = null;
                foreach (string s in uf)
                {
                    sr = new StreamReader(@"D:\Sonic\Cep\CEP.TXT", Encoding.GetEncoding("ISO-8859-1"));
                    valor = new StreamWriter(@"D:\Sonic\Cep\" + s + ".TXT", false, Encoding.GetEncoding("ISO-8859-1"));
                    valor.Write("[ENDERECO]");
                    valor.WriteLine();
                    int count = 1;
                    string line = sr.ReadLine();

                    String row = String.Empty;
                    // LAÇO PA CONCATENAR AS LINHAS E MONTAR A QUERY
                    while (line != null)
                    {
                        row = line.Replace("\t", ";");
                        if (row.IndexOf(s) == 9)
                        {
                            valor.Write(count + "=" + row + ";\n");
                            count += 1;
                        }

                        line = sr.ReadLine();

                    }
                    
                    valor.Close();
                    
                }

                return true;

            }

        }

    }
}
