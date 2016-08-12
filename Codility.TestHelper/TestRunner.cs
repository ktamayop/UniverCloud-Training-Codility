using UniverCloud.Training.Codility.TestCase;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloud.Training.Codility
{
    /// <summary>
    /// Ejecutor de casos de prueba.
    /// </summary>
    public class TestRunner
    {
        /// <summary>
        /// Runs a method with one argument
        /// </summary>
        /// <typeparam name="TTestData"></typeparam>
        /// <typeparam name="TIn1"></typeparam>
        /// <param name="testData"></param>
        public static SingleArgTestCase<TTestData, TIn1> FromTestData<TTestData, TIn1>(TTestData testData) where TTestData : ITestData
        {
            return new SingleArgTestCase<TTestData, TIn1>(testData);
        }

        /// <summary>
        ///     Runs a method with two arguments
        /// </summary>
        /// <typeparam name="TTestData"></typeparam>
        /// <typeparam name="TIn1"></typeparam>
        /// <typeparam name="TIn2"></typeparam>
        /// <param name="testData"></param>
        public static TwoArgsTestCase<TTestData, TIn1, TIn2> FromTestData<TTestData, TIn1, TIn2>(TTestData testData) where TTestData : ITestData
        {
            return new TwoArgsTestCase<TTestData, TIn1, TIn2>(testData);
        }

        /// <summary>
        ///     Runs a method with two arguments
        /// </summary>
        /// <typeparam name="TTestData"></typeparam>
        /// <typeparam name="TIn1"></typeparam>
        /// <typeparam name="TIn2"></typeparam>
        /// <param name="testData"></param>
        public static ThreeArgsTestCase<TTestData, TIn1, TIn2, TIn3> FromTestData<TTestData, TIn1, TIn2, TIn3>(TTestData testData) where TTestData : ITestData
        {
            return new ThreeArgsTestCase<TTestData, TIn1, TIn2, TIn3>(testData);
        }
    }
}