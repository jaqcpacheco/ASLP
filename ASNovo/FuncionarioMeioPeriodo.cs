public class FuncionarioMeioPeriodo : Funcionario, IBonus
{
    private int salarioPorhora;
    private int numeroHorasTrabalhadas;
    public int salarioMeioPeriodo;
    public int bonusMeioPeriodo;
    private double salarioMeioPeriodo1;

    public FuncionarioMeioPeriodo (string nome, int matriculaFuncionario, int numeroHorasTrabalhadas, int salarioPorhora)  : base(nome, matriculaFuncionario)
    {
    
        this.nome = nome;
        this.matriculaFuncionario = matriculaFuncionario;
        this.numeroHorasTrabalhadas = numeroHorasTrabalhadas; 
        this.salarioPorhora = salarioPorhora;
    }

    public override double CalcularSalario()
    {
        return salarioMeioPeriodo = numeroHorasTrabalhadas * salarioPorhora;
    }
        public double CalcularBonus()
    {
            return bonusMeioPeriodo = (int)(salarioMeioPeriodo * 0.5);
    }
}