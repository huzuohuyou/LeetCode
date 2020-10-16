using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{

    public class Solution_JZO12 : ISolution
    {
        public void Test()
        {
            var f = Exist(new char[][] {
                new char[] { 'C','A','A' }
            ,new char[] { 'A','A','A' }
            ,new char[] { 'B','C','D' }}, "AAB");
        }
        public bool Exist(char[][] board, string word)
        {
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[0].Length; j++)
                {
                    if (dfs(board, word, i, j, 0))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool dfs(char[][] board, string word, int x, int y, int index)
        {
            if (x < 0 || x > board.Length - 1
                || y < 0 || y > board[0].Length - 1
                || board[x][y] != word[index])
            {
                return false;
            }
            if (index == word.Length - 1)
            {
                return true;
            }
            char temp = board[x][y];
            board[x][y] = '#';

            var res = dfs(board, word, x - 1, y, index + 1)
                || dfs(board, word, x + 1, y, index + 1)
                || dfs(board, word, x, y - 1, index + 1)
                || dfs(board, word, x, y + 1, index + 1);
            board[x][y] = temp;
            return res;
        }
    }
}

