using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWork
{
    internal static class Class1
    {
        /// <summary>
        /// 演習問題1
        /// </summary>
        /// <returns></returns>
        internal static string Work01()
        {
            var result = string.Empty;
            var stb = new StringBuilder();
            var totalCnt = 0;
            for (int a = 1; a <= 100; a++)
            {
                for (int b = 1; b <= 100; b++)
                {
                    for (int c = 1; c <= 100; c++)
                    {
                        if(a*a+b*b != c*c)
                        {
                            continue;
                        }
                        stb.AppendLine(String.Format("a={0} b={1} c={2}", a, b, c));
                        totalCnt++;
                    }
                }
            }

            stb.AppendLine(String.Format("TotalCount{0}", totalCnt));
            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題2
        /// </summary>
        /// <returns></returns>
        internal static string Work02()
        {
            var result = string.Empty;
            var stb = new StringBuilder();
            var totalCnt = 0;
            var resultLst = new List<List<int>>();

            for (int a = 1; a <= 100; a++)
            {
                for (int b = 1; b <= 100; b++)
                {
                    for (int c = 1; c <= 100; c++)
                    {
                        if (a * a + b * b != c * c)
                        {
                            continue;
                        }

                        var linePattern = new List<int>();
                        linePattern.Add(a);
                        linePattern.Add(b);
                        linePattern.Add(c);
                        linePattern = linePattern.OrderBy(x=>x).ToList();

                        if(resultLst.Exists(x => x.SequenceEqual(linePattern)))
                        {
                            continue;
                        }

                        stb.AppendLine(String.Format("a={0} b={1} c={2}", a, b, c));
                        resultLst.Add(linePattern);
                        totalCnt++;
                    }
                }
            }

            stb.AppendLine(String.Format("TotalCount{0}", totalCnt));
            result = stb.ToString();
            return result;
        }

        #region 演習問題3
        /// <summary>
        /// 演習問題3
        /// </summary>
        /// <param name="input">インプット</param>
        /// <returns></returns>
        internal static string Work03(int input)
        {
            return Work03Sub(input).ToString();
        }
        private static int Work03Sub(int input)
        {
            if(input == 0)
            {
                return 1;
            }

            return input * Work03Sub( input - 1);
        }
        #endregion

        /// <summary>
        /// 演習問題4
        /// </summary>
        /// <returns></returns>
        internal static string Work04()
        {
            var result = string.Empty;

            var ram = new Random();
            var resultNum = ram.Next(1, 1000);

            result = String.Format("{0} 桁数{1}", resultNum, resultNum.ToString().Length);
            return result;
        }

        /// <summary>
        /// 演習問題5
        /// </summary>
        /// <returns></returns>
        internal static string Work05()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            for(int lpCnt = 1; lpCnt <= 100; lpCnt++)
            {
                if((lpCnt % 3) == 0)
                {
                    stb.AppendLine(lpCnt.ToString());
                }
                else if(lpCnt.ToString().IndexOf('3') != -1)
                {
                    stb.AppendLine(lpCnt.ToString());
                }
            }
            result = stb.ToString();
            return result;
        }

    }
}
