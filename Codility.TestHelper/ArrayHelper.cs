using System.Linq;
using System.Text;

namespace UniverCloud.Training.Codility
{
    /// <summary>
    /// Helper to print array data.
    /// </summary>
    public static class ArrayHelper
    {
        /// <summary>
        /// Prints an array. If the array length is greater that <param name="thresholdToCut"></param> the output is truncated and only <param name="takeWhenTresholdIsActive"></param> items will be printed.
        /// </summary>
        /// <param name="a">The array to print.</param>
        /// <param name="thresholdToCut">Limit above which output is abbreviated.</param>
        /// <param name="takeWhenTresholdIsActive">Total items to print when threshold is reached.</param>
        public static string PrintArray(int[] a, int thresholdToCut = 10, int takeWhenTresholdIsActive = 3)
        {
            var sb = new StringBuilder(); 
            sb.Append("a=[");
            if (a.Length > thresholdToCut)
            {
                var firstElements = a.Take(takeWhenTresholdIsActive);
                foreach (var n in firstElements)
                    sb.AppendFormat("{0}, ", n);

                sb.Append(" ... ");

                var lastElements = a.Skip(a.Length - takeWhenTresholdIsActive).Take(takeWhenTresholdIsActive);
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