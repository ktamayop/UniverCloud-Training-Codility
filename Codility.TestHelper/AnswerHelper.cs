using System;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloud.Training.Codility
{
    internal class AnswerHelper
    {
        public static void ShowAnswer<TTestData, TResult>(TTestData testData, TResult result, Func<TResult, string> showResult, TimeSpan elapsed) where TTestData : ITestData
        {
            Console.WriteLine("Results running {0}:", testData);
            Console.WriteLine("\tInpt:    {0}", testData.PrintInputData());
            Console.WriteLine("\tAnsw:    {0}", showResult(result));
            Console.WriteLine("\tTime:    {0} ms", elapsed.TotalMilliseconds);
            Console.WriteLine("--------------------");
            Console.WriteLine("");
        }
    }
}
