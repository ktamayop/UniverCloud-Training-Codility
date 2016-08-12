using System;
using System.Diagnostics;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloud.Training.Codility.TestCase
{
    /// <summary>
    /// Un caso de prueba con un solo argumento de entrada.
    /// </summary>
    /// <typeparam name="TTestData"></typeparam>
    /// <typeparam name="TIn"></typeparam>
    public sealed class SingleArgTestCase<TTestData, TIn> : TestCaseBase where TTestData : ITestData
    {
        public SingleArgTestCase(TTestData testData)
        {
            TestData = testData;
        }

        /// <summary>
        /// Data para el test
        /// </summary>
        private TTestData TestData { get; set; }

        /// <summary>
        /// Ejecutar el método
        /// </summary>
        /// <typeparam name="TResult">Tipo del Resultado</typeparam>
        /// <param name="runFunc">Función a ejecutar</param>
        /// <param name="showResultFunction">Función para mostrar el resultado.</param>
        /// <returns></returns>
        public TResult Run<TResult>(Func<TIn, TResult> runFunc, Func<TResult, string> showResultFunction)
        {
            //Inicializar la data 
            TestData.Initialize();

            //medir el tiempo de ejecución
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            //ejecutar la operación del caso de prueba
            var result = runFunc(TestData.GetArg<TIn>());

            //detener el cronometro
            stopWatch.Stop();

            //Mostrar la respuesta
            AnswerHelper.ShowAnswer(TestData, result, showResultFunction, stopWatch.Elapsed);

            //devolver el resultado
            return result;
        }
    }
}