using System;
using ClassGenerator.ClassBuilders;

namespace ClassGenerator.ClassBuilders
{
    public static class ClassBuilder
    {
        public static void GerarInterface(string nameSpace, string nomeArquivo)
        {
            throw new NotImplementedException();
        }

        public static void GerarClasse(string nameSpace, string nomeArquivo)
        {
            throw new NotImplementedException();
        }

        public static void GerarEntity(string nameSpace, string nomeEntity)
        {
            EntityBuilder.CreateEntity(nameSpace, nomeEntity);
        }

        public static void GerarAppService(string nameSpace, string nomeEntity)
        {
            AppServiceBuilder.CreateAppService(nameSpace, nomeEntity);
        }

        public static void GerarIAppService(string nameSpace, string nomeEntity)
        {
            IAppServiceBuilder.CreateIAppService(nameSpace, nomeEntity);
        }

        public static void GerarDomainService(string nameSpace, string nomeEntity)
        {
            DomainServiceBuilder.CreateDomainService(nameSpace, nomeEntity);
        }

        public static void GerarIDomainService(string nameSpace, string nomeEntity)
        {
            IDomainServiceBuilder.CreateIDomainService(nameSpace, nomeEntity);
        }

        public static void GerarIDomainServiceRepository(string nameSpace, string nomeEntity)
        {
            IDomainServiceRepositoryBuilder.CreateIDomainServiceRepository(nameSpace, nomeEntity);
        }

        public static void GerarRepository(string nameSpace, string nomeEntity)
        {
            RepositoryBuilder.CreateRepository(nameSpace, nomeEntity);
        }
    }
}
