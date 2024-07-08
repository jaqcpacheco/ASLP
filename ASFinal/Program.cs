public class Program
{
    public static void Main(string[] args)
    {
        Empresa empresa = new Empresa();

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Adicionar funcionário de tempo integral");
            Console.WriteLine("2. Adicionar funcionário de meio período");
            Console.WriteLine("3. Remover funcionário");
            Console.WriteLine("4. Exibir informações de todos os funcionários");
            Console.WriteLine("5. Adicionar projeto(s) a um funcionário");
            Console.WriteLine("6. Sair do programa");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Nome: ");
                    string nome = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    int matricula = int.Parse(Console.ReadLine());
                    Console.Write("Salário mensal: ");
                    double salarioMensal = double.Parse(Console.ReadLine());

                    FuncionarioTempoIntegral funcionario = new FuncionarioTempoIntegral(nome, matricula, salarioMensal);
                    empresa.AdicionarFuncionario(funcionario);
                    break;

                case 2:
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Matrícula: ");
                    matricula = int.Parse(Console.ReadLine());
                    Console.Write("Salário por hora: ");
                    double salarioPorHora = double.Parse(Console.ReadLine());
                    Console.Write("Horas trabalhadas: ");
                    int horasTrabalhadas = int.Parse(Console.ReadLine());

                    FuncionarioMeioPeriodo funcionarioMeioPeriodo = new FuncionarioMeioPeriodo(nome, matricula, salarioPorHora, horasTrabalhadas);
                    empresa.AdicionarFuncionario(funcionarioMeioPeriodo);
                    break;

                case 3:
                    Console.Write("Matrícula do funcionário a remover: ");
                    matricula = int.Parse(Console.ReadLine());
                    empresa.RemoverFuncionario(matricula);
                    break;

                case 4:
                    empresa.ExibirFuncionarios();
                    break;

                case 5:
                    Console.Write("Matrícula do funcionário: ");
                    matricula = int.Parse(Console.ReadLine());
                    Funcionario funcionarioSelecionado = empresa.funcionarios.Find(f => f.Matricula == matricula);

                    if (funcionarioSelecionado!= null)
                    {
                        Console.Write("Projeto(s) a adicionar: ");
                        string projetos = Console.ReadLine();
                        funcionarioSelecionado.AdicionarProjeto(projetos.Split(','));
                    }
                    else
                    {
                        Console.WriteLine("Funcionário não encontrado.");
                    }
                    break;

                case 6:
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}