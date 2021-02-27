using System;
using linear_equation_solution2.DataModel;
using linear_equation_solution2.Tools;

namespace linear_equation_solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Дано квадратное уравнение вида
            // 5x-3=0
            var vars = new Variables()
            {
                A = 5,
                B = 3
            };

            //Инструмент для решения линейного уравнения
            var solver = new LinearSolver();

            //Результат решения линейного уравнения
            var root = solver.Solve(vars);

            //Вывод результата программы
            if (root.HasRoots)
            {
                Console.WriteLine($"x = {root.Root}");
            }
            else
            {
                Console.WriteLine("a=0, вычислеие невозможно");
            }

            Console.ReadKey();
        }
    }
}
