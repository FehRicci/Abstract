// See https://aka.ms/new-console-template for more information

using Abstract.Entities;

Console.Write("Entre com o numero de pagadores: ");
int pag = int.Parse(Console.ReadLine());

List<Pessoa> pagadores = new List<Pessoa>();

for  (int i = 1; i <= pag; i++)
{
    Console.WriteLine($"Pagador {i} : ");
    Console.Write("Pessoa Física ou Jurídica (f/j)? ");
    char ch = char.Parse(Console.ReadLine());
    
    if (ch == 'f')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Renda Anual: ");
        double renda = double.Parse(Console.ReadLine());
        Console.Write("Gastos com saúde: ");
        double saude = double.Parse(Console.ReadLine());
        pagadores.Add(new PessoaFisica(saude, nome, renda));
    }else if (ch == 'j')
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Renda Anual: ");
        double renda = double.Parse(Console.ReadLine());
        Console.Write("Quantidade de funcionários: ");
        int funcionarios = int.Parse(Console.ReadLine());
        pagadores.Add(new PessoaJuridica(funcionarios, nome, renda));
    }
}

Console.WriteLine();

Console.WriteLine("Impostos pagados: ");
double impostos = 0;
foreach (Pessoa p in pagadores)
{
    Console.WriteLine(p.Nome + ": R$ " + p.CalculoImposto().ToString("F2"));
    impostos += p.CalculoImposto();
}

Console.WriteLine("Total de Impostos: R$ " + impostos);