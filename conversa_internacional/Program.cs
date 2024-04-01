using System;

class MainClass
{
    public static void Main(string[] args)
    {
        int a, b, cont = 0;
        string c = "", ca = "";

        a = int.Parse(Console.ReadLine());

        for (int i = 0; i < a; i++)
        {

            b = int.Parse(Console.ReadLine());

            for (int j = 0; j < b; j++)
            {
                c = Console.ReadLine();
                if (j == 0)
                {
                    ca = c;
                }

                if (ca == c)
                {
                    cont++;
                }

                ca = c;

            }

            if (cont == b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine("ingles");
            }

            cont = 0;

        }
        Console.ReadKey();

    }
}
