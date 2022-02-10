namespace Calculator
{
    /// <summary>
    /// Provides simple math calculations
    /// </summary>
    public interface ISimpleCalculator
    {
        /// <summary>
        /// Adds two values
        /// </summary>
        /// <param name="A">First input</param>
        /// <param name="B">Second input</param>
        /// <returns>Calculated result</returns>
        int Add(int A, int B);

        /// <summary>
        /// Substracts two values
        /// </summary>
        /// <param name="A">First input</param>
        /// <param name="B">Second input</param>
        /// <returns>Calculated result</returns>
        int Subtract(int A, int B);

        /// <summary>
        /// Multiplies two values
        /// </summary>
        /// <param name="A">First input</param>
        /// <param name="B">Second input</param>
        /// <returns>Calculated result</returns>
        int Multiply(int A, int B);

        /// <summary>
        /// Divides two values
        /// </summary>
        /// <param name="A">First input</param>
        /// <param name="B">Second input</param>
        /// <returns>Calculated result</returns>
        int Divide(int A, int B);
    }
}
