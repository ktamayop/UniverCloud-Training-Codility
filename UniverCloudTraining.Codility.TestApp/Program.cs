using System.Text;
using UniverCloud.Training.Codility;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloudTraining.Codility.TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var problem = new Solution();

            //Run 1st overload
            TestRunner
                .FromTestData<TestData, int[], int>(new TestData(new[] { 3, 8, 9, 7, 6 }, 3))
                .Run(problem.solution, result =>
                {
                    var sb = new StringBuilder("A=[");
                    foreach (var item in result)
                    {
                        sb.AppendFormat("{0}, ", item);
                    }

                    sb.Append("]");
                    return sb.ToString();
                });

            //Run 2nd overload
            TestRunner
                .FromTestData<ArrayTestData, int[]>(new ArrayTestData(new[] { 9, 3, 9, 3, 9, 7, 9 }))
                .Run(new Solution().solution, result => result.ToString());
        }

        class Solution
        {
            public int[] solution(int[] A, int K)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                //validar array vacío
                if (A.Length == 0)
                    return A;

                var result = (int[])A.Clone();

                // write your code in C# 6.0 with .NET 4.5 (Mono)
                for (var i = 0; i < K; i++)
                {
                    //tomar el último elemento
                    var last = result[A.Length - 1];

                    //recorrer desde el segundo
                    for (var j = result.Length - 1; j > 0; j--)
                    {
                        //traer la posición anterior a la actual
                        result[j] = result[j - 1];
                    }

                    //Guardar en el primer elemento el que teniamos de ultimo.
                    result[0] = last;
                }

                return result;
            }

            public int solution(int[] A)
            {
                // write your code in C# 6.0 with .NET 4.5 (Mono)
                var lastPos = A.Length;
                for (var i = 0; i < lastPos; i++)
                {
                    var foundPair = false;
                    for (var j = i + 1; j < lastPos; j++)
                    {
                        if (A[i] != A[j])
                            continue;

                        //traer la última pos para j y decrementar la ultima pos
                        A[j] = A[lastPos - 1];
                        lastPos--;
                        foundPair = true;
                        break;
                    }

                    if (!foundPair)
                        return A[i];
                }

                //must not happen
                return 0;
            }
        }
    }
}
