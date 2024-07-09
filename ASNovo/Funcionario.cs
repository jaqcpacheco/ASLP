using System;
using System.Collections.Generic;

public abstract class Funcionario
{
    public string nome;
    public int matriculaFuncionario;
    public List<string> projetos = new List<string> { "Marketing", "Criação e Design", "Desenvolvimento de Software", "Segurança Cibernética" };
    public Funcionario (string nome, int matriculaFuncionario)
    {
        this.nome = nome;
        this.matriculaFuncionario = matriculaFuncionario;
    }
    public static void AdicionarProjeto(string projeto)
    {

    }

    public List<string> Projetos { get => projetos; set => projetos = value; }



    public abstract double CalcularSalario();

    
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}, Matrícula: {matriculaFuncionario}, Salário: {CalcularSalario}");
        Console.WriteLine("Projetos: " + string.Join(", ", Projetos));
    }

}
