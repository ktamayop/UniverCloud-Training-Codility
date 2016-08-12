namespace UniverCloud.Training.Codility.TestData
{
    /// <summary>
    /// Representa las funcionalidades para un conjunto de datos de prueba.
    /// </summary>
    public interface ITestData
    {
        /// <summary>
        /// Imprime la entrada de datos
        /// </summary>
        /// <returns></returns>
        string PrintInputData();

        /// <summary>
        /// Inicializa la data para este juego de datos.
        /// </summary>
        void Initialize();

        /// <summary>
        /// Obtiene el argumento de entrada N - ésimo para este juego de datos
        /// </summary>
        /// <typeparam name="TArg">Tipo del argumento</typeparam>
        /// <param name="pos">Posición del argumento</param>
        /// <returns></returns>
        TArg GetArg<TArg>(int pos = 0);
    }
}