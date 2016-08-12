using System.Linq;
using System.Text;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloudTraining.Codility.TestApp
{
    /// <summary>
    /// Una clase que representa un juego de datos en los que la entrada es un arreglo, que contiene un número impar de elementos y que cada elemento está repetido menos uno.
    /// </summary>
    public class PairedArrayTestData : TestDataBase
    {
        private int size;
        private bool initialized;

        /// <summary>
        /// Inicializa una instancia de este juego de datos y la longitud del arreglo de entrada es aleatoria.
        /// </summary>
        public PairedArrayTestData()
        {
            size = Random.Next(1, 1000001);
        }

        /// <summary>
        /// Inicializa una instancia de este juego de datos y al arreglo de entrada le asigna una longitud especificada por parámetro
        /// </summary>
        /// <param name="n"></param>
        public PairedArrayTestData(int n)
        {
            size = n;
        }

        /// <summary>
        /// Inicializa una instancia de este juego de datos y al arreglo de entrada le asigna el arreglo especificado.
        /// </summary>
        /// <param name="A"></param>
        public PairedArrayTestData(int[] A)
        {
            size = A.Length;
            Args = new object[] { A };

            initialized = true;
        }

        /// <summary>
        /// Permite inicializar la data de este juego de datos. Si no está inicializado, 
        /// </summary>
        public override void Initialize()
        {
            if (initialized)
                return;

            if (size % 2 == 0)
                size++;

            var data = new int[size];
            for (var i = 0; i < data.Length / 2; i++)
            {
                data[i] = Random.Next(1, 1000000001);

                //generar la posición que empareja esta
                int pairPos;
                do
                {
                    pairPos = Random.Next(0, size);
                } while (data[pairPos] != 0);

                //emparejar
                data[pairPos] = data[i];
            }

            Args = new object[] { data };

            initialized = true;
        }

        /// <summary>
        /// Permite imprimir la data de entrada de este juuego de datos (debe redefinirse en las clases hijas)
        /// </summary>
        /// <returns></returns>
        public override string PrintInputData()
        {
            var a = GetArg<int[]>();
            var sb = new StringBuilder(string.Format("N={0}. A=[", a.Length));

            if (a.Length > 10)
            {
                var firstElements = a.Take(3);
                foreach (var n in firstElements)
                    sb.AppendFormat("{0}, ", n);

                sb.Append(" ... ");

                var lastElements = a.Skip(a.Length - 3).Take(3);
                foreach (var n in lastElements)
                    sb.AppendFormat("{0}, ", n);
            }
            else
            {
                foreach (var n in a)
                    sb.AppendFormat("{0}, ", n);
            }

            var result = sb.ToString();
            return result.Substring(0, result.Length - 2) + "]";
        }
    }
}