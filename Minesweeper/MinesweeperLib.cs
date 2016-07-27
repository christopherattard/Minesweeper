using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperLib
{
    public class MinesweeperLib
    {
        public const int MINE = 11;
        List<FieldInfo> _fieldList = new List<FieldInfo>();
        int[] _data = null;

        public void ProcessFields()
        {
            foreach (FieldInfo f in _fieldList)
            {
                int[][] adjacentMatrix = new int[f.Lines][];
                for (int i = 0; i < f.Lines; i++)
                {
                    adjacentMatrix[i] = new int[f.Columns];
                }

                for (int i = 0; i < f.Lines; i++)
                {
                    for (int j = 0; j < f.Columns; j++)
                    {
                        adjacentMatrix[i][j] += f.GetAdjacentMines(i, j);
                    }
                }
            }
        }
    }
}
