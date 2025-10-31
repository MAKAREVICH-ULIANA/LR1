using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] triangles = { { 3, 3, 3 }, { 5, 5, 8 }, { 3, 4, 5 }, { 1, 2, 3 } };
        CheckTriangles(triangles);
    }

    static void CheckTriangles(int[,] tris)
    {
        for (int i = 0; i < tris.GetLength(0); i++)
        {
            int a = tris[i, 0], b = tris[i, 1], c = tris[i, 2];

            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Равносторонний треугольник");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Равнобедренный треугольник");
                else
                    Console.WriteLine("Разносторонний треугольник");
            }
            else
            {
                Console.WriteLine("Такой треугольник не существует");
            }
        }
    }
}