using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber15
{
    class Program
    {
        static void Main(string[] args)
        {
            int menuchoice = 0;
            string country;
            string continent;
            List<Country> Countries = new List<Country>();
            string countryFile = "../../Countries.txt";
            StreamReader countryReader = new StreamReader(countryFile);
            string countryData = countryReader.ReadToEnd();      
            var countryRecords = countryData.Split('\n');
            foreach (var record in countryRecords)
            {
                var rc = record.Split(',');
                country = rc[0];
                Countries.Add(new Country(country));
            }
            countryReader.Close();

            Console.WriteLine("Welcome to the Countries Database. Please make a selection: ");
            while (menuchoice != 3)
            {
                Console.WriteLine("1. List existing countries");
                Console.WriteLine("2. Add new country");
                Console.WriteLine("3. Exit");
                menuchoice = int.Parse(Console.ReadLine());

                switch (menuchoice)
                {
                    case 1:
                        for (int i = 0; i < Countries.Count; i++)
                        {
                            Console.WriteLine(Countries[i]);
                        }
                        break;
                    case 2:
                        countryReader.Close();
                        Console.Write("Enter country name: ");
                        country = Console.ReadLine();
                        Console.Write("Enter continent: ");
                        continent = Console.ReadLine();
                        Countries.Add(new Country(country));
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid entry, try again: ");
                        menuchoice = int.Parse(Console.ReadLine());
                        break;
                }
            }


        }
    }
}
