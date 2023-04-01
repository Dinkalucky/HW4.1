using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._6
{
    public class NumbersArr
    {
        public IEnumerable<double> SqrtNums(int[] ints)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i] % 2 != 0)
                {
                    yield return Math.Pow(ints[i], 2);
                }
            }
        }
    }
}
