using System;
using ClassGenerator.ClassBuilders;

namespace ClassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int tipoProjeto = 0;
            //int tipoArquivo = 0;
            string nameSpaceEntity = "";
            string nameSpaceAppService = "";
            string nameSpaceIAppService = "";
            string nameSpaceDomainService = "";
            string nameSpaceIDomainService = "";
            string nameSpaceDomainServiceIRepository = "";
            string nameSpaceRepository = "";
            string nomeEntity = "";

            Console.WriteLine("Informe o tipo de projeto:");
            Console.WriteLine("1 para DDD:");
            Console.WriteLine("2 para Padrao:");
            tipoProjeto = Convert.ToInt32(Console.ReadLine());


            switch (tipoProjeto)
            {
                case 1:

                    Console.WriteLine("Informe o namespace da Entity:");
                    Console.WriteLine("Ex.:<NomeProjeto>.Domain.Entities");
                    nameSpaceEntity = Console.ReadLine();

                    Console.WriteLine("Informe o nome da Entity:");
                    nomeEntity = Console.ReadLine();

                    Console.WriteLine("Informe o namespace do DomainService IRepository:");
                    Console.WriteLine("Ex.: <NomeProjeto>.Contracts.Repositories -> Projeto.Domain.Contracts.Repositories");
                    nameSpaceDomainServiceIRepository = Console.ReadLine();

                    Console.WriteLine("Informe o namespace do Repository:");
                    Console.WriteLine("Ex.: <NomeProjeto>.Repositories -> Projeto.Infra.Repository.Repositories");
                    nameSpaceRepository = Console.ReadLine();

                    Console.WriteLine("Informe o namespace do IDomainService:");
                    Console.WriteLine("Ex.: <NomeProjeto>.Contracts.DomainServices.Interfaces -> Projeto.Domain.Contracts.DomainServices.Interfaces");
                    nameSpaceIDomainService = Console.ReadLine();

                    Console.WriteLine("Informe o namespace do DomainService:");
                    Console.WriteLine("E.: <NomeProjeto>.Contracts.DomainServices -> Projeto.Domain.Contracts.DomainServices");
                    nameSpaceDomainService = Console.ReadLine();

                    Console.WriteLine("Informe o namespace do IAppService:");
                    Console.WriteLine("Ex.: <NomeProjeto>.Contracts -> Projeto.Application.Contracts ");
                    nameSpaceIAppService = Console.ReadLine();

                    Console.WriteLine("Informe o namespace do AppService:");
                    Console.WriteLine("Ex.: <NomeProjeto>.Services -> Projeto.Application.Services");
                    nameSpaceAppService = Console.ReadLine();

                    ClassBuilder.GerarEntity(nameSpaceEntity, nomeEntity);
                    ClassBuilder.GerarIDomainServiceRepository(nameSpaceDomainServiceIRepository, nomeEntity);
                    ClassBuilder.GerarRepository(nameSpaceRepository, nomeEntity);
                    ClassBuilder.GerarIDomainService(nameSpaceIDomainService, nomeEntity);
                    ClassBuilder.GerarDomainService(nameSpaceDomainService, nomeEntity);
                    ClassBuilder.GerarIAppService(nameSpaceIAppService, nomeEntity);
                    ClassBuilder.GerarAppService(nameSpaceAppService, nomeEntity);

                    break;

                case 2:
                    Console.WriteLine("Funcionalidade não implementada");
                    // Console.WriteLine("Informe o tipo de arquivo deseja criar.");
                    // Console.WriteLine("1 para Classe:");
                    // Console.WriteLine("2 para Interface:");
                    // tipoArquivo = Convert.ToInt32(Console.ReadLine());
                    break;

                default:
                    break;
            }

        }


    }
}
