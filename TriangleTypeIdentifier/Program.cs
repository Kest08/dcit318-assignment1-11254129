using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter side A: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter side B: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter side C: ");
        int c = int.Parse(Console.ReadLine());

        if (a == b && b == c)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");
    }
}

// ready to be committed