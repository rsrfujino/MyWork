using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MyWork
{
    internal static class Class1
    {
        /// <summary>
        /// 演習問題1　ピタゴラス数　
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
                        if (a * a + b * b != c * c)
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
        /// 演習問題2　ピタゴラス数2
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
                        linePattern = linePattern.OrderBy(x => x).ToList();

                        if (resultLst.Exists(x => x.SequenceEqual(linePattern)))
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
        /// 演習問題3　階乗
        /// </summary>
        /// <param name="input">インプット</param>
        /// <returns></returns>
        internal static string Work03(int input)
        {
            return Work03Sub(input).ToString();
        }
        private static int Work03Sub(int input)
        {
            if (input == 0)
            {
                return 1;
            }

            return input * Work03Sub(input - 1);
        }
        #endregion

        /// <summary>
        /// 演習問題4　桁数
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
        /// 演習問題5　世界のナベアツ
        /// </summary>
        /// <returns></returns>
        internal static string Work05()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            for (int lpCnt = 1; lpCnt <= 100; lpCnt++)
            {
                if ((lpCnt % 3) == 0)
                {
                    stb.AppendLine(lpCnt.ToString());
                }
                else if (lpCnt.ToString().IndexOf('3') != -1)
                {
                    stb.AppendLine(lpCnt.ToString());
                }
            }
            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題8　約数
        /// </summary>
        /// <returns></returns>
        internal static string Work08()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var ram = new Random();
            var ramNum = ram.Next(1, 1000);

            stb.AppendLine(String.Format("乱数：{0}", ramNum));

            for (int i = 1; i <= ramNum; i++)
            {
                if (ramNum % i == 0)
                {
                    stb.AppendLine(i.ToString());
                }
            }

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題9　完全数
        /// </summary>
        /// <returns></returns>
        internal static string Work09()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            for (int lpCnt = 1; lpCnt <= 10000; lpCnt++)
            {
                var targetNums = new List<int>();
                for (int i = 1; i < lpCnt; i++)
                {
                    if (lpCnt % i != 0)
                    {
                        continue;
                    }

                    targetNums.Add(i);
                }

                if (lpCnt == targetNums.Sum())
                {
                    stb.AppendLine(String.Format("{0}", lpCnt));
                }
            }

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題10　数値の分類
        /// </summary>
        /// <returns></returns>
        internal static string Work10()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var ram = new Random();
            var nums = new List<int>();

            for (int lpCnt = 0; lpCnt < 10; lpCnt++)
            {
                nums.Add(ram.Next(1, 100));
            }

            var result1 = new List<int>();
            var result2 = new List<int>();

            nums.ForEach(x =>
            {
                if (x % 2 == 0)
                {
                    result1.Add(x);
                }
                else
                {
                    result2.Add(x);
                }
            });

            stb.AppendLine(string.Format("配列 {0}", string.Join(", ", nums)));
            stb.AppendLine(string.Format("偶数 {0}", string.Join(", ", result1)));
            stb.AppendLine(string.Format("奇数 {0}", string.Join(", ", result2)));

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題11　フィボナッチ数列
        /// </summary>
        /// <returns></returns>
        internal static string Work11()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var num1 = 0;
            var num2 = 1;
            var isLoop = true;
            stb.AppendLine(num2.ToString());
            while (isLoop)
            {
                var tmp = num1;
                num1 = num2;
                num2 = tmp + num2;
                stb.AppendLine(num2.ToString());
                if (num2 > 40)
                {
                    isLoop = false;
                }
            }

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題12　トリボナッチ数列
        /// </summary>
        /// <returns></returns>
        internal static string Work12()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var num1 = 0;
            var num2 = 1;
            var num3 = 1;
            var isLoop = true;
            stb.AppendLine(num3.ToString());
            while (isLoop)
            {
                var tmp = num1 + num2 + num3;
                num1 = num2;
                num2 = num3;
                num3 = tmp;
                stb.AppendLine(num2.ToString());
                if (num3 > 30)
                {
                    isLoop = false;
                }
            }

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題13　集合
        /// </summary>
        /// <returns></returns>
        internal static string Work13()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var ram = new Random();
            var list1 = new List<int>();
            var list2 = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list1.Add(ram.Next(1, 10));
                list2.Add(ram.Next(1, 10));
            }

            var resultCom = new List<int>();
            var resultAll = list1.Distinct().ToList();

            list2.ForEach(x =>
            {
                if (resultAll.Exists(y => x == y))
                {
                    if (!resultCom.Exists(y => x == y))
                    {
                        resultCom.Add(x);
                    }
                }
                else
                {
                    resultAll.Add(x);
                }
            });

            stb.AppendLine(string.Format("配列1 {0}", string.Join(' ', list1)));
            stb.AppendLine(string.Format("配列2 {0}", string.Join(' ', list2)));
            stb.AppendLine(string.Format("共通 {0}", string.Join(' ', resultCom)));
            stb.AppendLine(string.Format("全部 {0}", string.Join(' ', resultAll)));

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題14　エラトステネスのふるい
        /// </summary>
        /// <returns></returns>
        internal static string Work14()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var list1 = new List<int>();
            for (int i = 2; i <= 100; i++)
            {
                list1.Add(i);
            }

            var isLoop = true;
            var currentNum = 0;
            var results = new List<int>();
            while (isLoop)
            {
                currentNum = list1.Min();
                list1.RemoveAll(x => x % currentNum == 0);
                results.Add(currentNum);

                if (!list1.Any())
                {
                    isLoop = false;
                }
            }

            stb.AppendLine(string.Format("配列 {0}", string.Join(' ', results)));

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題15　素因数分解
        /// </summary>
        /// <returns></returns>
        internal static string Work15()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var ram = new Random();
            var num = ram.Next(2, 10000);
            var results = new List<int>();
            var currentNum = num;
            for (int i = 2; i <= num; i++)
            {
                currentNum = Work15Sub(currentNum, i, results);
                if (currentNum < i)
                {
                    break;
                }
            }

            stb.AppendLine(string.Format("数値 {0}", num));
            stb.AppendLine(string.Format("配列 {0}", string.Join(' ', results)));

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題15Subメソッド
        /// </summary>
        /// <returns></returns>
        internal static int Work15Sub(int targetNum, int num, List<int> results)
        {
            if (targetNum % num != 0)
            {
                return targetNum;
            }

            results.Add(num);
            return Work15Sub(targetNum / num, num, results); ;
        }

        /// <summary>
        /// 演習問題16　ソート
        /// </summary>
        /// <returns></returns>
        internal static string Work16()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var ram = new Random();
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(ram.Next(1, 100));
            }

            for (int i = 0; i < list.Count; i++)
            {
                var tmp = list.Skip(i).Max();
                list.Remove(tmp);
                list.Insert(i, tmp);
            }

            stb.AppendLine(string.Format("配列 {0}", string.Join(' ', list)));

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題16　ソート
        /// 手抜きVer
        /// </summary>
        /// <returns></returns>
        internal static string Work16_2()
        {
            var result = string.Empty;
            var stb = new StringBuilder();

            var ram = new Random();
            var list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(ram.Next(1, 100));
            }

            stb.AppendLine(string.Format("配列 {0}", string.Join(' ', list.OrderByDescending(x => x))));

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題17　友愛数
        /// </summary>
        /// <returns></returns>
        internal static string Work17()
        {
            var result = string.Empty;
            var stb = new StringBuilder();
            var results = new List<(int main, int sub)>();

            var ram = new Random();
            // 1～10000まで数値を全Loop
            for (int currentNum = 1; currentNum <= 10000; currentNum++)
            {
                var mainList = new List<int>();
                // 約数取得
                for (int i = 1; i < currentNum; i++)
                {
                    if(currentNum % i == 0)
                    {
                        mainList.Add(i);
                    }
                }

                // 友愛数の候補値取得
                var subNum = mainList.Sum();

                // 友愛数の候補値が処理している数値以下の場合は次の数値へ
                // 例)220,284
                //    284,220 ←既に[220]の友愛数にて捕捉されている組み合わせのため処理を行わない
                if(currentNum >= subNum)
                {
                    continue;
                }

                // 友愛数候補地の約数取得
                var subList = new List<int>();
                for (int i = 1; i < subNum; i++)
                {
                    if (subNum % i == 0)
                    {
                        subList.Add(i);
                    }
                }

                // 友愛数の場合処理結果に追加
                if(currentNum == subList.Sum())
                {
                    results.Add((currentNum,subNum));
                }
            }

            results.ForEach(x =>
            {
                stb.AppendLine(string.Format("{0} {1}", x.main, x.sub));
            });

            result = stb.ToString();
            return result;
        }

        /// <summary>
        /// 演習問題18　ロッカー
        /// </summary>
        /// <returns></returns>
        internal static string Work18()
        {
            var result = string.Empty;
            var stb = new StringBuilder();
            var list = new List<bool>();
            for (int i = 0; i < 50; i++)
            {
                list.Add(false);
            }

            var ram = new Random();
            // 1～10000まで数値を全Loop
            for (int currentNum = 1; currentNum <= 50; currentNum++)
            {
                // パターン１
                //for (int i = 1; i <= 50; i++)
                //{
                //    if (i % currentNum == 0)
                //    {
                //        list[i - 1] = !list[i - 1];
                //    }
                //}

                // パターン２
                for (int i = 1; i <= 50; i++)
                {
                    var index = currentNum * i;
                    if (currentNum * i > 50)
                    {
                        break;
                    }

                    list[index - 1] = !list[index - 1];
                }
            }

            var openCount = list.Sum(x =>
            {
                if (x)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            });

            stb.AppendLine(string.Format("空いてる個数{0}", openCount));
            stb.AppendLine(string.Format("配列 {0}", string.Join(' ', list)));

            result = stb.ToString();
            return result;
        }
    }
}
