public class FuncionarioMeioPeriodo : Funcionario, IBonus
    {
        private double SalarioPorHora;
        private int HorasTrabalhadas;

        public FuncionarioMeioPeriodo(string nome, int matricula, double salarioPorHora, int horasTrabalhadas) : base(nome, matricula)
        {
            SalarioPorHora = salarioPorHora;
            HorasTrabalhadas = horasTrabalhadas;
        }

        public override double CalcularSalario()
        {
            return SalarioPorHora * HorasTrabalhadas;
        }

        public double CalcularBonus()
        {
            return CalcularSalario() * 0.05;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Salário por Hora: {SalarioPorHora:C}, Horas Trabalhadas: {HorasTrabalhadas}, Salário Total: {CalcularSalario():C}, Bônus: {CalcularBonus():C}");
            Console.WriteLine("Projetos: " + string.Join(", ", Projetos));
        }
    }