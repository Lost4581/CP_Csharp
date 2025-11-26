using Lezhnev_CatFramework;

namespace Lezhnev_CatApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter cats count: ");
            uint catsCount = uint.Parse(Console.ReadLine());
            Cat[] cats = GenerateRandomCats(catsCount);

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();
            DisplayCatInfo(cats, path);
        }

        static Cat[] GenerateRandomCats(uint count)
        {
            Cat[] cats = new Cat[count];

            for (int i = 0; i < count; i++)
            {
                var rnd = new Random();
                int number = rnd.Next(0, 2);

                if (number == 0)
                {
                    double minWeight = 50.0;
                    double maxWeight = 160.0;
                    double weight = rnd.NextDouble() * (maxWeight - minWeight) + minWeight;

                    int fluffiness = rnd.Next(-20, 120);

                    try
                    {
                        Tiger tiger = new Tiger(weight, fluffiness);
                        cats[i] = tiger;
                    }

                    catch (CatException ex)
                    {
                        Console.WriteLine($"An exception has occurred: {ex.Message}");
                        i--;
                    }
                }

                else if (number == 1)
                {
                    int fluffiness = rnd.Next(-20, 120);

                    try
                    {
                        CuteCat cuteCat = new CuteCat(fluffiness);
                        cats[i] = cuteCat;
                    }

                    catch (CatException ex)
                    {
                        Console.WriteLine($"An exception has occurred: {ex.Message}");
                        i--;
                    }
                }
            }

            return cats;
        }

        static void DisplayCatInfo(Cat[] catsArr, string path)
        {
            using var writer = new StreamWriter(path, append: false);

            foreach (var cat in catsArr)
            {
                string line1 = cat.FluffinessCheck();
                string line2 = cat.ToString();

                Console.WriteLine(line1);
                Console.WriteLine(line2);

                writer.WriteLine(line1);
                writer.WriteLine(line2);
            }
        }
    }
}
