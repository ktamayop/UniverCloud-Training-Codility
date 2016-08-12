using System;

namespace UniverCloud.Training.Codility.TestData
{
    /// <summary>
    ///     Una clase que implementa el contrato de ITestData y provee un randomizador. Útil para inicializar datos aleatorios.
    /// </summary>
    public class TestDataBase : ITestData
    {
        protected readonly Random Random = new Random(Environment.TickCount);
        protected object[] Args;

        /// <summary>
        ///     Permite imprimir la data de entrada de este juuego de datos (debe redefinirse en las clases hijas)
        /// </summary>
        /// <returns></returns>
        public virtual string PrintInputData()
        {
            return string.Empty;
        }

        /// <summary>
        ///     Se redefine en los herederos y permite inicializar la data de este juego de datos. Por defecto no hace nada.
        /// </summary>
        public virtual void Initialize()
        {
        }

        /// <summary>
        /// Obtiene el argumento de la posición <paramref name="pos"/>.
        /// </summary>
        /// <typeparam name="TArg">Tipo del argumento</typeparam>
        /// <param name="pos">Posición del argumento en la lista de argumentos del juego de datos.</param>
        /// <returns></returns>
        public virtual TArg GetArg<TArg>(int pos = 0)
        {
            if (Args == null)
                return default(TArg);

            if (pos < 0 || pos >= Args.Length)
                throw new ArgumentOutOfRangeException("pos");

            return (TArg)Args[pos];
        }

        /// <summary>
        /// Devuelve el nombre de la clase.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return GetType().Name;
        }
    }
}