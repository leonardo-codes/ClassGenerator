using System;
using System.IO;
using System.Text;

namespace ClassGenerator.ClassBuilders
{
    public static class AppServiceBuilder
    {
        public static void CreateAppService(string nameSpace, string nomeEntity)
        {
            // Open the file to read from.
            string arquivo = File.ReadAllText(@"/Users/leonardomayrink/Desktop/Leo/pro-projects/ClassGenerator/Templates/AppServiceTemplate.txt");

            arquivo = arquivo.Replace(":nameSpace", nameSpace);
            arquivo = arquivo.Replace(":nomeEntity", nomeEntity);

            // string currentPath = Directory.GetCurrentDirectory();
            // string target = Directory.GetParent(currentPath.ToString()).ToString();
            // Console.WriteLine("The current directory is {0}", currentPath);
            // if (!Directory.Exists(target))
            // {
            //     Directory.CreateDirectory(target);
            // }


            string target = @"/Users/leonardomayrink/Desktop/Leo/pro-projects/ClassGenerator/bin/Debug/netcoreapp3.1/ArquivosGerados/";
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            string path = @target + "AppService" + nomeEntity + ".cs";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.WriteAllText(path, arquivo);
            }

        }
    }
}
