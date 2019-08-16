using System;
using System.IO;
using System.Windows.Forms;

namespace Integrador
{
    class Util
    {

        Arquivo arquivo = new Arquivo();

        public static string FirstCharToUpper(string value)
        {
            char[] array = value.ToCharArray();

            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    if (char.IsLower(array[i]))
                    {
                        array[i] = char.ToUpper(array[i]);
                    }
                }
            }
            return new string(array);
        }

        public class Arquivo {
            public void createFolder(string f, bool enviorement)
            {
                String ambient = String.Empty;
                if (enviorement)
                {
                    ambient = System.IO.Path.GetDirectoryName(Application.ExecutablePath);
                    if (!Directory.Exists(ambient + f))
                    {

                        System.IO.Directory.CreateDirectory(ambient + f);

                    }
                }
                else {

                    if (!Directory.Exists(f))
                    {

                        System.IO.Directory.CreateDirectory(f);

                    }
                }

            }
        }
      
    }
}
