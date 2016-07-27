using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinesweeperLib
{
    public class FieldInfo
    {
        public int Lines { get; set; }
        public int Columns { get; set; }

        string[] _field = null;
        int _addIndex = 0;

        public FieldInfo(int lines, int columns)
        {
            Lines = lines;
            Columns = columns;
            _field = new string[lines];            
        }

        public bool AddLine(string line)
        {
            if (_addIndex == Lines)
            {
                return false;
            }
            else
            {
                _field[_addIndex++] = line;
                return true;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="line">zero-based</param>
        /// <param name="column">zero-based</param>
        /// <returns></returns>
        public int GetAdjacentMines(int line, int column)
        {
            //Check if current cell is a mine
            if (_field[line][column].Equals('*'))
                return MinesweeperLib.MINE;

            int adjacentMines = 0;
            
            //Search the upper line, same line and below line for mines
            for (int i = -1; i < 2; i++)
            {
                if ((line + i > 0) && (line + i < Lines))
                {
                    for (int j = -1; j < 2; j++)
                    {
                        if ((column + j > 0) && (column + i < Columns))
                        {
                            if (_field[line + i][column + j].Equals('*'))
                                adjacentMines++;
                        }
                    }
                }
            }

            return adjacentMines;
        }

    }
}
