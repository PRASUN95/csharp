using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;

namespace LinqProgramCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //count file extensions

            #region
            //string[] files = new string[]
            //{
            //    "str.txt","asd.png","ast.doc","wst.TXT","xyz.abc.pdf","aaaa.PDF","abc.xml"
            //};
            //var excnt = files.Select(file => Path.GetExtension(file).TrimStart('.').ToLower()).
            //    GroupBy(x => x, (ext, extCount) => new
            //    {
            //        Extension = ext,
            //        ExtCount = extCount.Count()
            //    });
            //foreach(var ob in excnt)
            //{
            //    Console.WriteLine("{0} {1}",ob.Extension,ob.ExtCount);
            //}

            //int[] a = new int[]
            //{
            //    3,4,2,4,5,6
            //};
            ////   Array.Sort(a, new ValueComparator());
            //Array.Sort(a, (x, y) => x.CompareTo(y));
            //string s = "";
            //foreach(int el in a)
            //{
            //    s += el.ToString();
            //}
            //Console.WriteLine(s);
            #endregion
            int[] a = new int[]
            {
                3,4,2,4,5,6
            };
            LinqPrograSmCsharp.Sorting.BubbleSort(ref a);
            printArray(a);
            Console.ReadKey();
        }

        static void printArray(int[] a)
        {
            foreach (var e in a)
                Console.Write("{0} ", e);
        }
    
    }
  
    public class ValueComparator : IComparer
    {
        public int Compare(object ob1, object ob2)
        {
            string a = ob1.ToString(), b = ob2.ToString();
            string x = a + b, y = b + a;
            //Console.WriteLine($"{x} {y} {string.Compare(x,y)}");
            return y.CompareTo(x);
        }
    }
}


public class Solution
{
    public string LargestNumber(int[] nums)
    {
        Array.Sort(nums, (x, y) => (y + "" + x).CompareTo(x + "" + y));
        return nums[0] == 0 ? "0" : string.Join("", nums);
    }
}

public class Solution1
{
    public string LargestNumber(int[] nums)
    {
        var strNums = nums.Select(n => n.ToString()).ToArray();
        Array.Sort(strNums, (a, b) => string.Compare(b + a, a + b, StringComparison.Ordinal));

        StringBuilder sb = new StringBuilder();

        foreach (var w in strNums)
            sb.Append(w);
        string ans = sb.ToString().TrimStart('0');
        return ans == "" ? "0" : ans;

    }
}