
public class Empresa
{
    public List<Funcionario> Funcionarios { get; private set; }

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
        Funcionarios.RemoveAll(f => f.MatriculaFuncionario == matricula);
    }

    public void ExibirFuncionarios()
    {
        foreach (var funcionario in Funcionarios)
        {
            funcionario.ExibirInformacoes();
            Console.WriteLine();
        }
    }

    public Funcionario BuscarFuncionarioPorMatricula(int matricula)
    {
        return Funcionarios.Find(f => f.MatriculaFuncionario == matricula);
    }
}/*namespace As
{
    public class Empresa
    {
        public List<string> Funcionario = [];
        public void AdicionarFuncionarios(Funcionario funcionario) { }
        public void Removerfuncionario(Funcionario funcionario) { }
        public void ExibirFuncionarios(Funcionario funcionario) { }

    }
}*/