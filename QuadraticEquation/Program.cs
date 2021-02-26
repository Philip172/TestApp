using QuadraticEquation.DataModel;
using QuadraticEquation.Tools;
using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дано квадратное уравнение вида
            // x^2+2x-3=0
            var quadratic = new Quadratic()
            {
                A = 1,
                B = 2,
                C = -3
            };

            // Инструмент для решения квадратного уравнения
            var resolver = new QuadraticSolver();

            // Результат решения квадратного уравнения
            var roots = resolver.Solve(quadratic);

            // Вывод результата решения задачи
            if (roots.HasRoots)
            {
                Console.WriteLine($"x1 = {roots.Root1}, x2 = {roots.Root2}");
            }
            else
            {
                Console.WriteLine("Корней нет");
            }

            Console.ReadKey();
        }
    }
}
