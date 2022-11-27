using System;

namespace homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Scrieti un program care citind de la tastaura cele trei dimensiuni ale unui
             paralelipiped dreptunghic, va afisa volumul lui
             */

            int latime;
            int lungime;
            int inaltime;

            Console.WriteLine("Introduceti latimea: ");
            latime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti lungimea: ");
            lungime = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea: ");
            inaltime = int.Parse(Console.ReadLine());

            int volumParalelipiped = latime * lungime * inaltime;
            Console.WriteLine("Volumul este: " + volumParalelipiped);
        }
    }
}
