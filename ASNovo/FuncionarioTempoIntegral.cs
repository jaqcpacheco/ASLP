public class FuncionarioTempoIntegral : Funcionario, IBonus
    {
        private double SalarioMensal;

        public FuncionarioTempoIntegral(string nome, int matricula, double salarioMensal) : base(nome, matricula)
        {
            SalarioMensal = salarioMensal;
        }

        public override double CalcularSalario()
        {
            return SalarioMensal;
        }

        public double CalcularBonus()
        {
            return SalarioMensal * 0.10;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário Mensal: {SalarioMensal:C}, Bônus: {CalcularBonus():C}");
            Console.WriteLine("Projetos: " + string.Join(", ", Projetos));
        }
    }