public class Empresa
    {
        private List<Funcionario> Funcionarios;

        public Empresa()
        {
            Funcionarios = new List<Funcionario>();
        }

        public void AdicionarFuncionario(Funcionario funcionario)
        {
            Funcionarios.Add(funcionario);
        }

        public void RemoverFuncionario(int matricula)
        {
            Funcionarios.RemoveAll(f => f.Matricula == matricula);
        }

        public void ExibirFuncionarios()
        {
            foreach (var funcionario in Funcionarios)
            {
                funcionario.ExibirInformacoes();
                Console.WriteLine();
            }
        }

        public Funcionario ObterFuncionario(int matricula)
        {
            return Funcionarios.Find(f => f.Matricula == matricula);
        }
    }
