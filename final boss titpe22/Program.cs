using System;
using System.IO;
using System.Linq;

namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LINQ");

            //kutsume WhereLINQ meetodi välja
            AggregateLINQ();
            MaxLINQ();
            PyramiidLINQ();
            TextToFileLINQ();

            string ch = Console.ReadLine(); 

            switch(ch)
            {
                case "1":
                    Console.WriteLine("AggregateLINQ();");
                    break;

                case "2":
                    Console.WriteLine("MaxLINQ()");
                    break;

                case "3":
                    Console.WriteLine("PyramiidLINQ();");
                    break;

                case "4":
                    Console.WriteLine("TextToFileLINQ();");
                    break;
            }
        }

        public static void AggregateLINQ()
        {
                string commaSeparatedPersonNames = PeopleList.peoples
                    .Aggregate<PeopleList, string>(
                    "People names: ",
                    (str, x) => str += x.Name + ", "
                    );

                Console.WriteLine(commaSeparatedPersonNames);
        }

        public static void MaxLINQ()
        {
            Console.WriteLine("Max LINQ");

            var max = PeopleList.peoples.Max();
            //var max = PeopleList.peoples.Max();

            Console.WriteLine("People Id: {0}, Student name: {1}");
            _ = (max.Id, max);
            //Console.WriteLine("People Id: {0}, Student name: {1}",
            //max.Id, max);  
        }

        public static void TextToFileLINQ()
        {
            Console.WriteLine("Kui url on vale, siis annab" +
               "veateate. Kui on õige, siis ütleb, " +
               "et kõik on korras");
            Console.WriteLine("Kui on ]ige, siis loob faili " +
                "koos sinu sisestatud tekstiga");


            string wrongPath = "V:/Users/Opilane/Desktop/FileToDesktop.txt";
            string wrightPath = "C:/Users/Opilane/Desktop/FileToDesktop.txt";

            Console.WriteLine("Tee valik numbriga:");
            Console.WriteLine("1 on vale url");
            Console.WriteLine("2 on õige url");
            string choose = Console.ReadLine();

            if (choose == "1")
            {
                try
                {
                    string inputText = Console.ReadLine();
                    File.WriteAllText(wrongPath, inputText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ei salevstanud desktopile file kuna " +
                        "seda urli ei ole");
                    Console.WriteLine(ex.Message);
                }
            }
            if (choose == "2")
            {
                string inputText = Console.ReadLine();
                File.WriteAllText(wrightPath, inputText);

                Console.WriteLine("Salvestas edukalt desktopile");
            }
        }

        public static void PyramiidLINQ()
        {
            int i, j, rows, k = 1;

            Console.WriteLine("Näita numbri kolmnurka");

            Console.Write("Sisesta ridade arv:");
            rows = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= rows; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.Write("\n");
            }


        }
    }
}   