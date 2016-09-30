using System.Text;

namespace UniverCloud.Training.Codility.TestData
{
    /// <summary>
    /// Una clase que representa un juego de datos en los que la entrada es un arreglo.
    /// </summary>
    public class ArrayTestData : TestDataBase
    {
        private readonly int size;
        private bool initialized;

        /// <summary>
        /// Inicializa una instancia de este juego de datos y la longitud del arreglo de entrada es aleatoria.
        /// </summary>
        public ArrayTestData()
        {
            size = Random.Next(1, 1000001);
        }

        /// <summary>
        /// Inicializa una instancia de este juego de datos y al arreglo de entrada le asigna una longitud especificada por parámetro
        /// </summary>
        /// <param name="n"></param>
        public ArrayTestData(int n)
        {
            size = n;
        }

        /// <summary>
        /// Inicializa una instancia de este juego de datos y al arreglo de entrada le asigna el arreglo especificado.
        /// </summary>
        /// <param name="A"></param>
        public ArrayTestData(int[] A)
        {
            size = A.Length;
            Args = new object[] { A };

            initialized = true;
        }

        /// <summary>
        /// Permite inicializar la data de este juego de datos. Por defecto no hace nada. 
        /// </summary>
        public override void Initialize()
        {
            if (initialized)
                return;

            var data = new int[size];
            for (var i = 0; i < data.Length; i++)
                data[i] = Random.Next(1, 1000000001);

            //Guarda el arreglo como el argumento de la clase.
            Args = new object[] { data };

            //marcar como inicializado.
            initialized = true;
        }

        /// <summary>
        /// Permite imprimir la data de entrada de este juuego de datos (debe redefinirse en las clases hijas)
        /// </summary>
        /// <returns></returns>
        public override string PrintInputData()
        {
            var a = GetArg<int[]>();
            var sb = new StringBuilder(string.Format("N={0}. ", a.Length));
            sb.Append(ArrayHelper.PrintArray(a));
            return sb.ToString();
        }
    }
}