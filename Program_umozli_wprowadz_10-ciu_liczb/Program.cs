using System;

class Program
{
    static void Main()
    {
        double[] numbers = new double[10];
        Console.WriteLine("Wprowadź 10 liczb rzeczywistych:");

        // Wprowadzanie liczb do tablicy
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Liczba {i + 1}: ");
            while (!double.TryParse(Console.ReadLine(), out numbers[i]))
            {
                Console.WriteLine("Nieprawidłowy format liczby. Spróbuj ponownie.");
                Console.Write($"Liczba {i + 1}: ");
            }
        }

        int choice;
        do
        {
            // Menu wyboru
            Console.WriteLine("\nWybierz opcję:");
            Console.WriteLine("1 - Wyświetl tablicę od pierwszego do ostatniego indeksu");
            Console.WriteLine("2 - Wyświetl tablicę od ostatniego do pierwszego indeksu");
            Console.WriteLine("3 - Wyświetl elementy o nieparzystych indeksach");
            Console.WriteLine("4 - Wyświetl elementy o parzystych indeksach");
            Console.WriteLine("5 - Zakończ program");
            Console.Write("Twój wybór: ");

            // Odczytanie wyboru użytkownika
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                Console.Write("Twój wybór: ");
            }

            Console.WriteLine();

            // Obsługa opcji menu
            if (choice == 1)
            {
                Console.WriteLine("Tablica od pierwszego do ostatniego indeksu:");
                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            else if (choice == 2)
            {
                Console.WriteLine("Tablica od ostatniego do pierwszego indeksu:");
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            else if (choice == 3)
            {
                Console.WriteLine("Elementy o nieparzystych indeksach:");
                for (int i = 1; i < numbers.Length; i += 2)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            else if (choice == 4)
            {
                Console.WriteLine("Elementy o parzystych indeksach:");
                for (int i = 0; i < numbers.Length; i += 2)
                {
                    Console.Write(numbers[i] + " ");
                }
                Console.WriteLine();
            }
            else if (choice == 5)
            {
                Console.WriteLine("Koniec programu.");
            }
            else
            {
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
            }

        } while (choice != 5);
    }
}
