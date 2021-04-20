using System;

namespace RelembrandoFuncoesDotNet
{
    class Program
    {

        public static int SomaNumeros(int a, int b) //Criando função estática para rodar dentro do Console
        {
            return a + b;
        }

        public static void PrintaNome(string nome)
        {
            Console.WriteLine(nome);
        }
        
        public static void tabuada(int n)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} X {i} = {n*i}");
            }
            Console.WriteLine($"==============Fim Tabuada {n}==============");
        }

        static void Main(string[] args) //Quando se utiliza o tipo static você não cria uma instância da sua função
        {
            int retorno = SomaNumeros(10, 5);
            Console.WriteLine(retorno);
            PrintaNome("Lucas");

            tabuada(5);
            Console.Read();
        }
    }
}
