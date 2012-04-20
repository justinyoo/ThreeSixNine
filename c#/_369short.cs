using System;

namespace _369
{
    /// <summary>
    /// 숫자를 한글자씩 체크 
    /// --> 숫자(한글자) %3 몫이 0인면 369에 포함됨
    /// --> 박수를 친다.
    /// </summary>
    public class _369_short
    {
        public _369_short(int max)
        {
            for (int fi = 1; fi <= max; fi++)
            {
                for (int i = 0; i < fi.ToString().Trim().Length; i++)
                {
                    int chkNum = Int32.Parse(fi.ToString().Trim()[i].ToString());
                    if (chkNum != 0 && chkNum % 3 == 0)
                        Console.Write("짝");
                    else
                        Console.Write(chkNum);
                }
                Console.Write(", ");
            }
        }
    }
}
