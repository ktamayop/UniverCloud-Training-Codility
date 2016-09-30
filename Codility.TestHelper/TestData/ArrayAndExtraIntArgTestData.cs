using System;
using System.IO;
using System.Text;

namespace UniverCloud.Training.Codility.TestData
{
    /// <summary>
    /// Una clase que representa un juego de datos en los que la entrada es un arreglo y un valor adicional.
    /// A, N, D
    /// </summary>
    public class ArrayAndExtraIntArgTestData : TestDataBase
    {
        private readonly int size;
        private bool initialized;
        private readonly int d;

        /// <summary>
        /// Inicializa una instancia de este juego de datos y la longitud del arreglo de entrada es aleatoria.
        /// </summary>
        public ArrayAndExtraIntArgTestData()
        {
            size = Random.Next(1, (int)Math.Pow(10, 5) + 1);
            d = Random.Next(1, size + 1);
        }

        /// <summary>
        /// Inicializa una instancia de este juego de datos y al arreglo de entrada le asigna una longitud especificada por parámetro
        /// </summary>
        /// <param name="n"></param>
        /// <param name="d">Number of rotations in d</param>
        public ArrayAndExtraIntArgTestData(int n, int d)
        {
            size = n;
            this.d = d;
        }

        /// <summary>
        /// Inicializa una instancia de este juego de datos y al arreglo de entrada le asigna el arreglo especificado.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="d">Number of rotations</param>
        public ArrayAndExtraIntArgTestData(int[] A, int d)
        {
            size = A.Length;
            Args = new object[] { A, d };

            initialized = true;
        }

        /// <summary>
        /// Permite inicializar la data de este juego de datos. Por defecto no hace nada. 
        /// </summary>
        public override void Initialize()
        {
            if (initialized)
                return;

            //crear y llenar el arreglo con datos aleatorios.
            var data = new int[size];
            for (var i = 0; i < data.Length; i++)
                data[i] = Random.Next(1, (int) Math.Pow(10,6));

            //Guarda el arreglo y d en Args
            Args = new object[] { data, d };

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
            var d = GetArg<int>(1);
            var sb = new StringBuilder(string.Format("n={0}. d={1}. ", a.Length, d));
            sb.Append(ArrayHelper.PrintArray(a));
            return sb.ToString();
        }

        /// <summary>
        /// La entrada debe ser
        /// Linea 1: n y d (separados por espacio)
        /// Linea 2: a1 a2 a3 ... an (n numeros enteros separados por espacio)
        /// </summary>
        /// <param name="testFile">Fichero del cual cargar los datos</param>
        /// <returns></returns>
        public static ArrayAndExtraIntArgTestData FromFile(string testFile)
        {
            using (var reader = File.OpenText(testFile))
            {
                var tokens_n = reader.ReadLine().Split(' ');
                //NOT NEEDED -> var n = Convert.ToInt32(tokens_n[0]);
                var d = Convert.ToInt32(tokens_n[1]);
                var a_temp = reader.ReadLine().Split(' ');
                var a = Array.ConvertAll(a_temp, int.Parse);

                return new ArrayAndExtraIntArgTestData(a, d);
            }
        }
    }
}
