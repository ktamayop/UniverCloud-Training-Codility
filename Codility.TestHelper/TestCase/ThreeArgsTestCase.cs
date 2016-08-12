using System;
using System.Diagnostics;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloud.Training.Codility.TestCase
{
    /// <summary>
    /// Un caso de prueba con un solo argumento de entrada.
    /// </summary>
    /// <typeparam name="TTestData">Data para el test</typeparam>
    /// <typeparam name="TIn1">Tipo del primer argumento</typeparam>
    /// <typeparam name="TIn2">Tipo del segundo argumento</typeparam>
    /// <typeparam name="TIn3">Tipo del tercer argumento</typeparam>
    public sealed class ThreeArgsTestCase<TTestData, TIn1, TIn2, TIn3> : TestCaseBase where TTestData : ITestData
    {
        public ThreeArgsTestCase(TTestData testData)
        {
            TestData = testData;
        }

        /// <summary>
        /// Data para el test
        /// </summary>
        private TTestData TestData { get; set; }

        /// <summary>
        /// Run a maethod with 2 In parameters
        /// </summary>
        /// <typeparam name="TResult">Result</typeparam>
        /// <param name="runFunc">Function to Run</param>
        /// <param name="showResultFunction">Función para mostrar el resultado.</param>
        /// <returns></returns>
        public TResult Run<TResult>(Func<TIn1, TIn2, TIn3, TResult> runFunc, Func<TResult, string> showResultFunction)
        {
            //Inicializar la data 
            TestData.Initialize();

            //medir el tiempo de ejecución
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            //ejecutar la operación del caso de prueba
            var result = runFunc(TestData.GetArg<TIn1>(), TestData.GetArg<TIn2>(1), TestData.GetArg<TIn3>(2));

            //detener el cronometro
            stopWatch.Stop();

            //Mostrar la respuesta
            AnswerHelper.ShowAnswer(TestData, result, showResultFunction, stopWatch.Elapsed);

            //devolver el resultado
            return result;
        }
    }
}