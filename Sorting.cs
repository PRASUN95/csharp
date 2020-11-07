using System;
using System.Collections.Generic;
using System.Text;
namespace LinqPrograSmCsharp
{
    static class Sorting
    {
        public static void BubbleSort(ref int[] a)
        {
            int temp = 0;
            bool flag = true;
            for (int i = 0; i < a.Length; i++)
            {
                flag = true;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        flag = false;
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
                if (flag) break;
            }
        }
    }
}
