class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa();
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Adicionar funcionário de tempo integral");
                Console.WriteLine("2. Adicionar funcionário de meio período");
                Console.WriteLine("3. Remover funcionário");
                Console.WriteLine("4. Exibir informações de todos os funcionários");
                Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
                Console.WriteLine("6. Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        AdicionarFuncionarioTempoIntegral(empresa);
                        break;
                    case 2:
                        AdicionarFuncionarioMeioPeriodo(empresa);
                        break;
                    case 3:
                        RemoverFuncionario(empresa);
                        break;
                    case 4:
                        empresa.ExibirFuncionarios();
                        break;
                    case 5:
                        AdicionarProjetos(empresa);
                        break;
                    case 6:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Salário Mensal: ");
            double salarioMensal = double.Parse(Console.ReadLine());

            Funcionario funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
            empresa.AdicionarFuncionario(funcionario);
        }

        static void AdicionarFuncionarioMeioPeriodo(Empresa empresa)
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Matrícula: ");
            int matricula = int.Parse(Console.ReadLine());
            Console.Write("Salário por Hora: ");
            double salarioPorHora = double.Parse(Console.ReadLine());
            Console.Write("Horas Trabalhadas: ");
            int horasTrabalhadas = int.Parse(Console.ReadLine());

            Funcionario funcionario = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
            empresa.AdicionarFuncionario(funcionario);
        }

        static void RemoverFuncionario(Empresa empresa)
        {
            Console.Write("Matrícula do funcionário a ser removido: ");
            int matricula = int.Parse(Console.ReadLine());
            empresa.RemoverFuncionario(matricula);
        }

        static void AdicionarProjetos(Empresa empresa)
        {
            Console.Write("Matrícula do funcionário: ");
            int matricula = int.Parse(Console.ReadLine());
            Funcionario funcionario = empresa.ObterFuncionario(matricula);

            if (funcionario != null)
            {
                Console.WriteLine("1. Adicionar um projeto");
                Console.WriteLine("2. Adicionar vários projetos");
                int escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    Console.Write("Nome do projeto: ");
                    string projeto = Console.ReadLine();
                    funcionario.AdicionarProjeto(projeto);
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Digite os nomes dos projetos separados por vírgula:");
                    string[] projetos = Console.ReadLine().Split(',');
                    funcionario.AdicionarProjeto(new List<string>(projetos));
                }
            }
            else
            {
                Console.WriteLine("Funcionário não encontrado.");
            }
        }
    }
