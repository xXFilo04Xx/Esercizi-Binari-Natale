using System;

namespace Esercizi_Binari_Natale
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.MaxValue;
            Console.WriteLine(a); //viene stampato il numero massimo che un INT può contenere
            Console.WriteLine(a + 1); //il programma va in overflow perchè viene aggiunto un uno al numero massimo che 1 INT può contenere
            int b = -128;
            int c = -b;
            Console.WriteLine(Convert.ToString(b, 2));
            Console.WriteLine(Convert.ToString(c, 2));
            int value = 31;
            int somma = value;
            value = ~value + 1;
            //value = value+1;
            somma = somma + value;
            Console.WriteLine($"{value} e {somma}");
            long number = 55555;
            Console.WriteLine(Convert.ToString(number, 2));
            short number1 = (short)number;
            Console.WriteLine(number1);




        }
    }
}
