using System.Text;
using UniverCloud.Training.Codility.TestData;

namespace UniverCloudTraining.Codility.TestApp
{
    internal class TestData : TestDataBase
    {
        public TestData(int[] A, int K)
        {
            //Guardar los argumentos
            Args = new object[] { A, K };
        }

        public override string PrintInputData()
        {
            var sb = new StringBuilder();

            sb.AppendFormat("A=[");
            var a = GetArg<int[]>();
            foreach (var item in a)
                sb.AppendFormat("{0}, ", item);
            
            var k = GetArg<int>(1);
            sb.AppendFormat("]. K={0}", k);

            return sb.ToString();
        }
    }
}