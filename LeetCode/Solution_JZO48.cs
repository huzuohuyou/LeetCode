using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class Solution_JZO48 : ISolution
    {
        public void Test()
        {
            
        }

        public int LengthOfLongestSubstring(string s)
        {
            var dic = new Dictionary<char ,int>();
            int i = -1, res = 0;
            for (int j = 0; j < s.Length; j++)
            {
                if (dic.ContainsKey(s[j]))
                    i = Math.Max(i, dic[s[j]]); // 更新左指针 i
                dic[s[j]]= j; // 哈希表记录
                res = Math.Max(res, j - i); // 更新结果
            }
            return res;
        }

  

    }
}

