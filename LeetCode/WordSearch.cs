using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    public class WordSearch
    {
        public bool Exist(char[][] board, string word)
        {
            int R = board.Length;

            if (R == 0)
                return false;

            if (word.Length == 0)
                return false;

            int C = board[0].Length;
            char[] chars = word.ToCharArray();


            char firstChar = chars[0];


            for (int r = 0; r < R; r++)
                for (int c = 0; c < C; c++)
                    if (board[r][c] == firstChar)
                    {
                        if (chars.Length == 1)
                            return true;

                        bool[,] taken = new bool[R, C];
                        taken[r, c] = true;
                        if (BFS(board, r, c, taken, chars, 1))
                            return true;
                    }

            return false;
        }

        public bool BFS(char[][] board, int row, int col, bool[,] taken, char[] word, int nextIndex)
        {
            Console.WriteLine("BFS Variables: row={0}, col={1}, nextindex={2}", row, col, nextIndex);

            if (nextIndex == word.Length)
                return true;

            Queue<(int, int)> neighbors = GetNeighbors(board, row, col, taken);

            while (neighbors.Count > 0)
            {
                (int r, int c) = neighbors.Dequeue();

                if (word[nextIndex] == board[r][c])
                {
                    Console.WriteLine("Word at index {0} matched with board[{1}][{2}] which is {3}", nextIndex, r, c, word[nextIndex]);
                    taken[r, c] = true;
                    if (BFS(board, r, c, taken, word, nextIndex + 1))
                        return true;

                    // BackTrack
                    taken[r, c] = false;
                    Console.WriteLine("Backtracking Taken[{0}][{1}] from True to False");
                }

            }

            return false;
        }

        public Queue<(int, int)> GetNeighbors(char[][] board, int r, int c, bool[, ] taken)
        {
            Queue<(int, int)> neigbors = new Queue<(int, int)>();
            int[] left = new int[] { 0, 0, 1, -1 };
            int[] right = new int[] { -1, 1, 0, 0 };

            for (int i = 0; i < left.Length; i++)
                if (IsValid(board, r + left[i], c + right[i], taken))
                {
                    neigbors.Enqueue((r + left[i], c + right[i]));

                }

            return neigbors;
        }

        public bool IsValid(char[][] board, int r, int c, bool[,] taken)
        {
            int R = board.Length;
            int C = board[0].Length;

            return r >= 0 && r < R && c >= 0 && c < C && !taken[r, c];
        }

        public void Print(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write("{0}", string.Join(", ", matrix[i, j]));
            Console.WriteLine();
        }
    }
}
