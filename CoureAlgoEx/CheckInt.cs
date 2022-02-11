using System;
using System.Collections.Generic;
using System.Text;

namespace CoureAlgoEx
{
    public class CheckInt
    {
        public static int CheckIntVal(List<int> input)
        {
            var count = 0;
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] % 2 == 0)
                    count++;
                if (input[i] % 2 != 0)
                    count += 3;
                if (input[i] == 8)
                    count += 5;
            }

            return count;
        }
    }
}
