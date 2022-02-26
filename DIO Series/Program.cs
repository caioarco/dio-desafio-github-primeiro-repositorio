namespace DIO_Series
{


    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();
        static FilmeRepositorio repositorio2 = new FilmeRepositorio();
        static void Main()
        {
            string opcaoUsuario = ObterOpcaoUsuario();
            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                         AtualizarSerie();
                         break;
                    case "4":
                        ExcluirSerie();
                         break;
                    case "5":
                         VisualizarSerie();
                         break;
                    case "6":
                        ListarFilmes();
                        break;
                    case "7":
                        InserirFilme();
                        break;
                    case "8":
                         AtualizarFilme();
                         break;
                    case "9":
                        ExcluirFilme();
                         break;
                    case "10":
                         VisualizarFilme();
                         break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                opcaoUsuario = ObterOpcaoUsuario();
            }
        }

        private static void ListarSeries()
        {
            Console.WriteLine("Listar séries");
            var lista = repositorio.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhuma série foi encontrada");
                return;
            }
            foreach (var serie in lista)
            {
                var excluido = serie.retornaExcluido();
                
                Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }
        private static void InserirSerie()
        {
            Console.WriteLine("Inserir nova série");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Título da Série:" );
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

            Serie novaSerie = new Serie(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);
            repositorio.Insere(novaSerie);
        }

        private static void AtualizarSerie()
        {
            Console.WriteLine("Digite o id da Série: ");
            int indiceSerie = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o gênero entra as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Título da Série:" );
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de início da Série: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição da Série: ");
            string entradaDescricao = Console.ReadLine();

             Serie atualizaSerie = new Serie(id: indiceSerie,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao);

            repositorio.Atualiza(indiceSerie, atualizaSerie);

        }

        private static void ExcluirSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            
            repositorio.Exclui(indiceSerie);
        }

        private static void VisualizarSerie()
        {
            Console.WriteLine("Digite o id da série: ");
            int indiceSerie = int.Parse(Console.ReadLine());
            var serie = repositorio.RetornaPorId(indiceSerie);
            Console.WriteLine(serie);
        }


        private static void ListarFilmes()
        {
            Console.WriteLine("Listar filmes");
            var lista = repositorio2.Lista();
            if (lista.Count == 0)
            {
                Console.WriteLine("Nenhum filme foi encontrado");
                return;
            }
            foreach (var filme in lista)
            {
                var excluido = filme.retornaExcluido();
                
                Console.WriteLine("#ID {0}: - {1} {2}", filme.retornaId(), filme.retornaTitulo(), (excluido ? "*Excluido*": ""));
            }
        }

        private static void InserirFilme()
        {
            Console.WriteLine("Inserir novo filme");
            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
            }
            Console.WriteLine("Digite o gênero entre as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Título do filme:" );
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de Lançamento do filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite a faixa etária do filme: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

            Filme novoFilme = new Filme(id: repositorio.ProximoId(),
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        classificacao: entradaClassificacao);
            repositorio2.Insere(novoFilme);
        }

        private static void AtualizarFilme()
        {
            Console.WriteLine("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());

            foreach (int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine("{0} - {1}", i, Enum.GetName(typeof(Genero), i));
            }

            Console.WriteLine("Digite o gênero entra as opções acima: ");
            int entradaGenero = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Digite o Título do:" );
            string entradaTitulo = Console.ReadLine();

            Console.WriteLine("Digite o ano de lançamento do Filme: ");
            int entradaAno = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Descrição do Filme: ");
            string entradaDescricao = Console.ReadLine();

            Console.WriteLine("Digite a faixa etária do Filme: ");
            int entradaClassificacao = int.Parse(Console.ReadLine());

             Filme atualizaFilme = new Filme(id: indiceFilme,
                                        genero: (Genero)entradaGenero,
                                        titulo: entradaTitulo,
                                        ano: entradaAno,
                                        descricao: entradaDescricao,
                                        classificacao: entradaClassificacao);

            repositorio2.Atualiza(indiceFilme, atualizaFilme);

        }

        private static void ExcluirFilme()
        {
            Console.WriteLine("Digite o id do Filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            
            repositorio2.Exclui(indiceFilme);
        }

        private static void VisualizarFilme()
        {
            Console.WriteLine("Digite o id do filme: ");
            int indiceFilme = int.Parse(Console.ReadLine());
            var filme = repositorio2.RetornaPorId(indiceFilme);
            Console.WriteLine(filme);
        }


        private static string ObterOpcaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("DIOflix ao seu dispor!!!");
            Console.WriteLine("Informe a opção desejada");

            Console.WriteLine(" 1- Listar séries");
            Console.WriteLine(" 2- Inserir nova série");
            Console.WriteLine(" 3- Atualizar Série");
            Console.WriteLine(" 4- Excluir Série");
            Console.WriteLine(" 5- Visualizar Série");
            Console.WriteLine(" 6- Listar Filmes");
            Console.WriteLine(" 7- Inserir novo Filme");
            Console.WriteLine(" 8- Atualizar Filme");
            Console.WriteLine(" 9- Excluir Filme");
            Console.WriteLine("10- Visualizar Filme");
            Console.WriteLine("C- Limpar Tela");
            Console.WriteLine("X- Sair");

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;
        }
    }
}