using System;
using linear_equation_solution2.DataModel;

namespace linear_equation_solution2.Tools
{
    class LinearSolver
    {
        public Roots Solve(Variables V)
        {
            if (V.A == 0)
            {
                return new Roots
                {
                    HasRoots = false
                };
            }
            var root = -V.B / V.A;

            return new Roots()
            {
                HasRoots = true,
                Root = root
            };
        }
    }
}
