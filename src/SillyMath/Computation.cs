using SillyMath.Interfaces;
using System;

namespace SillyMath
{
    public class Computation : IComputation
    {
        public int MezzaSomma(int a, int b)
        {
            return (a + b) / 2;
        }
    }
}
