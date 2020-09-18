using System;
using System.IO;

namespace ClassGenerator.ClassBuilders
{
    public static class IDomainServiceRepositoryBuilder
    {
        public static void CreateIDomainServiceRepository(string nameSpace, string nomeEntity)
        {
            // Open the file to read from.
            string arquivo = File.ReadAllText(@"/Users/leonardomayrink/Desktop/Leo/pro-projects/ClassGenerator/Templates/IRepositoryTemplate.txt");

            arquivo = arquivo.Replace(":nameSpace", nameSpace);            
            arquivo = arquivo.Replace(":nomeEntity", nomeEntity);

            string target = @"/Users/leonardomayrink/Desktop/Leo/pro-projects/ClassGenerator/bin/Debug/netcoreapp3.1/ArquivosGerados/";            
            if (!Directory.Exists(target))
            {
                Directory.CreateDirectory(target);
            }

            string path = @target + "IRepository" + nomeEntity + ".cs";
            
            if (!File.Exists(path))
            {
                // Create a file to write to.
                File.WriteAllText(path, arquivo);
            }

        }
    }
}
