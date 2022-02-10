using System;

namespace Calculator
{
    /// <inheritdoc cref="ISimpleCalculator"/>
    public class EasyCalculator : ISimpleCalculator, IComplexCalculator
    {
        /// <inheritdoc cref="ISimpleCalculator.Add(int, int)"/>
        public int Add(int A, int B)
        {
            return A + B;
        }

        /// <inheritdoc cref="ISimpleCalculator.Subtract(int, int)"/>
        public int Subtract(int A, int B)
        {
            return A - B;
        }

        /// <inheritdoc cref="ISimpleCalculator.Multiply(int, int)"/>
        public int Multiply(int A, int B)
        {
            return A * B;
        }

        /// <inheritdoc cref="ISimpleCalculator.Divide(int, int)"/>
        public int Divide(int A, int B)
        {
            return A / B;
        }


        /// <inheritdoc cref="IComplexCalculator.Logarithm(double)"/>
        public double Logarithm(double A)
        {
            return Math.Log(A, 2);
        }
    }
}
