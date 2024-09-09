using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

namespace csharp_ekstraoppgaver;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int myInt = 9;
        int myEkstraInt = 8;
        int[] myArray = [1, 2, 3, 4, 5, 6, 7, 8, 9];
        



        // Oppgave 1

        Console.WriteLine(MyMethod(myInt, myEkstraInt));

        //Oppgave 2

        Console.WriteLine(SumArray(myArray));

        // Oppgave 3


        // Skaper et nytt Dictionary-objekt.
        Dictionary<string, int> myDictionary = new Dictionary<string, int>() 
        {
            {"Per", 14},
            {"Pål", 19},
            {"Espen", 12},
        };

        // Legger til et element i myDictionary.

        myDictionary.Add("Ola", 39);

        // Looper gjennomm myDictionary og skriver ut nøkkel-verdi-parene.

        foreach (var item in myDictionary)
        {
            Console.WriteLine($"{item.Key}: {item.Value}");
        }




    }


    // En enkel metode som tar to int-parametre og returnerer summen av de to som en int. 
    static int MyMethod(int x, int y) {
        int mySum = x + y;
        return x+y;
    }

    // En metode som legger sammen alle verdiene av et int-array, og returnerer summen. 
    static int SumArray(int[] array) {
        int sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }
        return sum;
    }


}
