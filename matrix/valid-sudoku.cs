public class Solution {
   public bool IsValidSudoku(char[][] board)
            {
                for (int i = 0; i < 9; i++)
                {
                    HashSet<char> ckrow = new HashSet<char>();
                    HashSet<char> ckcol = new HashSet<char>();
                    for (int j = 0; j < 9; j++)
                    {
                        if (ckrow.Contains(board[i][j]))
                        {
                            return false;
                        }
                        else if (board[i][j] != '.')
                        {
                            ckrow.Add(board[i][j]);
                        }
                        if (ckcol.Contains(board[j][i]))
                        {
                            return false;
                        }
                        else if (board[j][i] != '.')
                        {
                            ckcol.Add(board[j][i]);
                        }
                    }
                }
                int row = -1;
                int col = -1;
                while (col !=8)
                {
                    HashSet<char> ckrow = new HashSet<char>();
                    for (int relrow = row + 1; relrow <= row + 3; relrow++)
                    {
                        for (int relcol = col + 1; relcol <= col + 3; relcol++)
                        {
                            if (ckrow.Contains(board[relrow][relcol]))
                            {
                                return false;
                            }
                            else if (board[relrow][relcol] != '.')
                            {
                                ckrow.Add(board[relrow][relcol]);
                            }
                        }
                    }
                    row += 3;
                    if(row == 8 && col != 8)
                    {
                        row = -1;
                        col += 3;
                    }
                    ckrow.Clear();
                }
                return true;
            }
}