using System;

namespace Case2 // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string VichleType = Console.ReadLine();
            if(VichleType == CarLogoEnum.Bil.ToString())
            {
            Mechanic Martin = new Mechanic("Martin", "Jensen", 11111111, CarLogoEnum.Bil);
            }
            else if(VichleType == CarLogoEnum.Mortercykel.ToString())
            {
            Mechanic Thomas = new Mechanic("Thomas", "Hansen", 22222222, CarLogoEnum.Mortercykel);
            }
            else if(VichleType == CarLogoEnum.Lastbil.ToString())
            {
            Mechanic Henrik = new Mechanic("Henrik", "Nielsen", 33333333, CarLogoEnum.Lastbil);
            }
            //strKøretøjType.køretøjlist.add(new Car(parameter))


            Enrollment x = new();

            Console.WriteLine("Vælg");
            Console.WriteLine("1) Opret kunde");
            Console.WriteLine("2) Søg på kunde");
            Console.WriteLine("3) Søg på mekaniker");
            int fortheswich = int.Parse(Console.ReadLine());
            switch (fortheswich)
            {
                case 1:
                    Console.WriteLine("Skriv dit fornavn");
                    string firstname = Console.ReadLine();
                    Console.WriteLine("Skriv dit efternavn");
                    string lastname = Console.ReadLine();
                    Console.WriteLine("Skriv dit telefonummer");
                    int phonenumber = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv nummerplade");
                    int numberplate = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv bilens mærke");
                    string brand = Console.ReadLine();
                    Console.WriteLine("Skriv bilens model");
                    string model = Console.ReadLine();
                    Console.WriteLine("skriv bilens registerings årgang");
                    DateTime year = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Skriv køretøjs type (Bil, Lastbil, Motorcykel)");
                    string type = Console.ReadLine();

                    Viechle viechle1 = new Viechle(firstname, lastname, phonenumber, numberplate, brand, model, type);
                    break;
                case 2:

                break; 
                case 3:

                break;
            }

            Console.Clear();
        }
    } 
}