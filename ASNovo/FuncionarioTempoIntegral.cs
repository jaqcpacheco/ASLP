public class FuncionarioTempoIntegral : Funcionario , IBonus
{
    private double salarioMensal;
    public int bonusTempoIntegral;
    public FuncionarioTempoIntegral(string nome, int matriculaFuncionario, double salarioMensal) : base(nome, matriculaFuncionario)
    {
        this.nome = nome;
        this.matriculaFuncionario = matriculaFuncionario;
        this.salarioMensal = salarioMensal;
    }
    public override double CalcularSalario()
    {
        return salarioMensal;
    }
    public new void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {nome}, Matrícula: {matriculaFuncionario}, Salário: {CalcularSalario}");
        Console.WriteLine("Projetos: " + string.Join(", ", Projetos));
    }
    public double CalcularBonus()
    {
       return bonusTempoIntegral = (int)(salarioMensal *= 0.10);
    }
}