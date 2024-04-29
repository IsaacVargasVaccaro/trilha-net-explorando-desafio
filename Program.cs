using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes

Console.WriteLine("Qual será a quantidade de hóspedes que irão haver na suite?");
int n = int.Parse(Console.ReadLine());

List<Pessoa> hospedes = new List<Pessoa>(n);

for (int i = 0; i < n; i++)
{
    Console.Write($"Qual o nome completo do hóspede {i+1}? ");
    string nomeCompleto = Console.ReadLine();
    hospedes.Add(new Pessoa(nomeCompleto));  
}

// Cria a suíte
Console.Clear();
Console.Write("Qual o tipo da suite? ");
string tipoSuite = Console.ReadLine();
Console.Write("Qual a capacidade de hóspedes para essa suite? ");
int capacidade = int.Parse(Console.ReadLine());
Console.Write("Qual o valor da diária? ");
decimal valorDiaria = decimal.Parse(Console.ReadLine());

Suite suite = new Suite(tipoSuite, capacidade, valorDiaria);

Console.Clear();


// Cria uma nova reserva, passando a suíte e os hóspedes
Console.Clear();
Console.Write("A reserva é para quantos dias? ");
int diasReservados = int.Parse(Console.ReadLine());
Reserva reserva = new Reserva(diasReservados);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");