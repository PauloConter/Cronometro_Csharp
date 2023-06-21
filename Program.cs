using System;
using System.Threading; 
 
namespace dev 
{

    class Program
    {

        static void Main(string[] args)
        {
            
            Menu();
            
        }
        static void Menu() 
        {
            Console.Clear();
            Console.WriteLine("S = Segundo => 10s = 10 Segundos"); 
            Console.WriteLine("M = Minuto => 1m = 1 Minuto");
            Console.WriteLine("N =Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string Data = Console.ReadLine().ToLower();
            char type = char.Parse(Data.Substring(Data.Length - 1, 1));
            int Time = int.Parse(Data.Substring(0, Data.Length - 1));
            int mult = 1;

            if (type == 'm')
            {
                mult = 60;
            }
            if (Time == 0)
            {
                System.Environment.Exit(0);
            }

            PreStart(Time * mult);

        }

        static void PreStart(int Time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(Time);


        }

        // coloca a var dentro do parâmetro
        static void Start(int Time)
        {
            int currentTime = 0;

            while (currentTime != Time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Cronômetro finalizado");
            Thread.Sleep(2500);
            Menu();


        }
    }
}
