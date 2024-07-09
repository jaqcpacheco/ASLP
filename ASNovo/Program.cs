using System;
using System.Collections.Generic;
using As;

class Program
{
    static void Main(string[] args)
    {
        Empresa empresa = new Empresa();

        while (true)
        {
            ExibirMenu();

            int opcao = ObterOpcaoDoUsuario();

            switch (opcao)
            {
                case 1:
                    AdicionarFuncionarioTempoIntegral(empresa);
                    break;
            }
        }
    }
    private static void ExibirMenu()
    {
        Console.WriteLine("\nMenu:");
        Console.WriteLine("1. Adicionar Funcionário Tempo Integral");
        Console.WriteLine("2. Adicionar Funcionário Meio Período");
        Console.WriteLine("3. Remover Funcionário");
        Console.WriteLine("4. Exibir Informações de Todos os Funcionários");
        Console.WriteLine("5. Adicionar Projeto(s) a um Funcionário");
        Console.WriteLine("6. Sair");
        Console.Write("Escolha uma opção: ");
    }
    private static int ObterOpcaoDoUsuario()
    {
        if (int.TryParse(Console.ReadLine(), out int opcao))
        {
            return opcao;
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número.");
            return 0;
        }
    }
    private static void AdicionarFuncionarioTempoIntegral(Empresa empresa)
    {
        Console.WriteLine("Nome: ");
        string? nome = Console.ReadLine();
        Console.WriteLine("Matrícula: ");
        int matriculaFuncionario = int.Parse(Console.ReadLine());
        Console.WriteLine("Salário Mensal: ");
        double salarioMensal = double.Parse(Console.ReadLine());

        Funcionario funcionario = new FuncionarioTempoIntegral(nome, matriculaFuncionario, salarioMensal);
        empresa.AdicionarFuncionarios(funcionario);
        Console.WriteLine("Funcionário de tempo integral adicionado com sucesso.");
    }
}

      