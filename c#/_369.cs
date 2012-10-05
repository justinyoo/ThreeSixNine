using System;
using System.Linq;

namespace _369
{
    /// <summary>
    /// 1부터 max까지 숫자를 생성하여
    /// --> 판단하는 함수에게 넘겨줌 
    /// --> 숫자에서 369가 있는지를 박수를 친다.
    /// </summary>
    public class _369Box
    {
        private void xecut(int max)
        {
            for (int input = 1; input <= max; input++)
            {
                judgment(input);
            }
        }

        private void judgment(int judgmentNum)
        {
            string numStream = judgmentNum.ToString();
            if (numStream.Contains('3') || numStream.Contains('6') || numStream.Contains('9'))
            {
                Console.Write("사용자 : {0} ", judgmentNum);
                for (int i = 0; i < numStream.Length; i++)
                {
                    string compareStr = numStream[i].ToString();
                    if (compareStr == "3" || compareStr == "6" || compareStr == "9")
                    {
                        Console.Write("{0}", "짝");
                    }
                }
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("사용자 : {0}", judgmentNum);
            }
        }


        public _369Box(int numberStream)
        {
            xecut(numberStream);
        }
    }
}



   

