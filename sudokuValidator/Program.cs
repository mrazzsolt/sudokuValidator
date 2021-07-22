using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sudokuValidator
{
    class Program
    {
        public static bool ValidateSolution(int[][] board)
        {
            HashSet<int> duplicateWatcher =new HashSet<int>();
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    duplicateWatcher.Add(board[j][i]);
                    if(board[j][i]<1)
                    {
                        return false;
                    }
                    if(board[i][j]>9)
                    {
                        return false;
                    }
                }
                if (duplicateWatcher.Count < 9)
                {
                    return false;
                }
                duplicateWatcher.Clear();
            }
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    duplicateWatcher.Add(board[i][j]);
                    
                }
                if (duplicateWatcher.Count < 9)
                {
                    return false;
                }
                duplicateWatcher.Clear();
            }
           
            
            bool[] unique = new bool[10];
            for (int i = 0; i < 9 - 2; i += 3)
            {
                for (int j = 0; j < 9 - 2; j += 3)
                {
                    for (int z = 0; z < unique.Length; z++)
                    {
                        unique[z] = false;
                    }
                    
                    for (int k = 0; k < 3; k++)
                    {
                        for (int l = 0; l < 3; l++)
                        {
                            int X = i + k;
                            int Y = j + l;
                            int Z = board[X][Y];
                            if (unique[Z])
                            {
                                return false;
                            }
                            unique[Z] = true;
                        }
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            int[][] solution = new int[9][];
            solution[0] = new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 };
            solution[1] = new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 };
            solution[2] = new int[] { 1, 9, 8, 3, 4, 2, 5, 6, 7 };
            solution[3] = new int[] { 8, 5, 9, 7, 6, 1, 4, 2, 3 };
            solution[4] = new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 };
            solution[5] = new int[] { 7, 1, 3, 9, 2, 4, 8, 5, 6 };
            solution[6] = new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 };
            solution[7] = new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 };
            solution[8] = new int[] { 3, 4, 5, 2, 8, 6, 1, 7, 9 };
            int[][] solution2 = new int[9][];
            solution2[0] = new int[] { 5, 3, 4, 6, 7, 8, 9, 1, 2 };
            solution2[1] = new int[] { 6, 7, 2, 1, 9, 5, 3, 4, 8 };
            solution2[2] = new int[] { 1, 9, 8, 3, 0, 2, 5, 6, 7 };
            solution2[3] = new int[] { 8, 5, 0, 7, 6, 1, 4, 2, 3 };
            solution2[4] = new int[] { 4, 2, 6, 8, 5, 3, 7, 9, 1 };
            solution2[5] = new int[] { 7, 0, 3, 9, 2, 4, 8, 5, 6 };
            solution2[6] = new int[] { 9, 6, 1, 5, 3, 7, 2, 8, 4 };
            solution2[7] = new int[] { 2, 8, 7, 4, 1, 9, 6, 3, 5 };
            solution2[8] = new int[] { 3, 0, 0, 2, 8, 6, 1, 7, 9 };
            int[][] solution3 = new int[9][];
            solution3[0] = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            solution3[1] = new int[] { 2, 3, 1, 5, 6, 4, 8, 9, 7 };
            solution3[2] = new int[] { 3, 1, 2, 6, 4, 5, 9, 7, 8 };
            solution3[3] = new int[] { 4, 5, 6, 7, 8, 9, 1, 2, 3 };
            solution3[4] = new int[] { 5, 6, 4, 8, 9, 7, 2, 3, 1 };
            solution3[5] = new int[] { 6, 4, 5, 9, 7, 8, 3, 1, 2 };
            solution3[6] = new int[] { 7, 8, 9, 1, 2, 3, 4, 5, 6 };
            solution3[7] = new int[] { 8, 9, 7, 2, 3, 1, 5, 6, 4 };
            solution3[8] = new int[] { 9, 7, 8, 3, 1, 2, 6, 4, 5 };
            Console.WriteLine(ValidateSolution(solution));
            Console.WriteLine(ValidateSolution(solution2));
            Console.WriteLine(ValidateSolution(solution3));
            Console.ReadKey();
        }
    }
}
