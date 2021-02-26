using QuadraticEquation.DataModel;
using System;

namespace QuadraticEquation.Tools
{
    class QuadraticSolver
    {
        public Roots Solve(Quadratic q)
        {
            var d = q.B * q.B - 4 * q.A * q.C;

            if (d < 0)
                return new Roots() { HasRoots = false };

            var root1 = (-q.B + Math.Sqrt(d)) / (2 * q.A);
            var root2 = (-q.B - Math.Sqrt(d)) / (2 * q.A);

            return new Roots()
            {
                HasRoots = true,
                Root1 = root1,
                Root2 = root2
            };
        }
    }
}
