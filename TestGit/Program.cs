using System;

namespace TestGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1) Multipli");
            Console.WriteLine("2) Fattoriale");
            Console.WriteLine("3) Numeri primi");
            Console.WriteLine("4) Somma numeri");
            Console.WriteLine("5) Conta vocali");
            Console.WriteLine("6) Fibonacci");
            Console.Write("Scegli un programma: ");
            int scelta = int.Parse(Console.ReadLine());
            int numero = 0;

            switch (scelta)
            {
                case 1:
                    // Calcolo multipli fino a 100
                    Console.Write("Inserisci un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    Multipli(numero);
                    break;

                case 2:
                    // Calcolare il fattoriale di un numero
                    Console.Write("Inserisci un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    Fattoriale(numero);
                    break;

                case 3:
                    // Verificare se un numero è primo
                    Console.Write("Inserisci un numero: ");
                    numero = int.Parse(Console.ReadLine());

                    bool isPrimo = Primi(numero);
                    if (isPrimo)
                        Console.WriteLine($"{numero} è un numero primo.");
                    else
                        Console.WriteLine($"{numero} non è un numero primo.");
                    break;

                case 4:
                    // Somma numeri pari fino a 100
                    Console.Write("Inserisci un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    SommaPari(numero);
                    break;
                case 5:
                    // Conta vocali nelle frasi
                    Console.Write("Inserisci una frase: ");
                    string frase = Console.ReadLine();
                    ContaVocali(frase);
                    break;

                case 6:
                    // Fibonacci
                    Console.Write("Inserisci un numero: ");
                    numero = int.Parse(Console.ReadLine());
                    Fibonacci(numero);
                    break;

                default:
                    Console.WriteLine("Scelta non valida.");
                    break;
            }
        }

        public static void Multipli(int numero)
        {
            Console.WriteLine($"Multipli di {numero} fino a 100:");

            for (int i = 1; i <= 100; i++)
            {
                int multiplo = numero * i;
                if (multiplo > 100)
                    break;

                Console.WriteLine(multiplo);
            }
        }

        public static void Fattoriale(int numero)
        {
            Console.Write($"Fattoriale di {numero}: ");

            long fattoriale = 1;
            if (numero == 0) fattoriale = 0;

            for (int i = numero; i > 1; i--)
            {
                fattoriale *= i;
            }

            Console.Write(fattoriale);
        }

        public static bool Primi(int numero)
        {
            if(numero < 2) return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false; 
            }
            return true; 

        }

        public static void SommaPari(int numero)
        {
            int somma = 0;
            Console.WriteLine($"Numeri pari fino a {numero}");
            for (int i = 0; i < numero; i++) 
            {
                if (i % 2 == 0)
                {
                    somma += i;
                }
            }
            Console.WriteLine($"La somma dei numeri pari fino a {numero} (escluso) è: {somma}");
        }

        public static void ContaVocali(string frase)
        {
            string vocali = "aeiouAEIOU";
            int count = 0;

            foreach(char lettera in frase)
            {
                if(vocali.Contains(lettera))
                {
                    count++;
                }
            }

            Console.WriteLine("Vocali trovate: " + count);
        }

        static void Fibonacci(int n)
        {
            int a = 0, b = 1, temp;
            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }
            Console.WriteLine($"Il numero di Fibonacci alla posizione {n} è {a}");
        }
    }
}
