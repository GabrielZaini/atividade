using System;

namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
           Cliente boguiba = new Cliente();
           boguiba.Cpf = "555.444.666-23";
           boguiba.Nome = "boguiba";
           boguiba.Rua = "R. cude cego";
           boguiba.Numero = 666;
           boguiba.Bairro = "caminho sem caminho";
           boguiba.Cidade = "tetolandia";
           boguiba.Cep = "14140-666";
           boguiba.CidadeNome = "tetolandia";
           boguiba.EstadoNome = "sou lindo";
           boguiba.EstadoSigla = "SL";
           Console.WriteLine("Nome: " + boguiba.Nome);
           Console.WriteLine("Cpf: " + boguiba.Cpf);
           Console.WriteLine("Rua: " + boguiba.Rua);
           Console.WriteLine("Numero: " + boguiba.Numero);
           Console.WriteLine("Bairro: " + boguiba.Bairro);
           Console.WriteLine("Cidade: " + boguiba.Cidade);
           Console.WriteLine("Cep: " + boguiba.Cep);
           Console.WriteLine("EstanoNome: " + boguiba.EstadoNome);
           Console.WriteLine("Estadosigla: " + boguiba.EstadoSigla);
        }
    }
}

