using System;
using System.Collections;
using System.Collections.Generic;

namespace PascalsTriangle
{
    class Program
    {
         public IList<IList<int>> Generate(int numRows) 
        {
            IList<IList<int>> pascalsTriangle = new List<IList<int>>();
            if (numRows == 0)
            {
                return pascalsTriangle;
            }

            List<int> firstRow = new List<int>();
            firstRow.Add(1);
            pascalsTriangle.Add(firstRow);


            for (int i = 1; i < numRows; i++)
            {
                List<int> row = new List<int>();
                row.Add(1);
                for (int j = 1; j < i; j++)
                {
                    row.Add(pascalsTriangle[i-1][j-1] + pascalsTriangle[i-1][j]);
                }
                row.Add(1);
                pascalsTriangle.Add(row);
            }

            return pascalsTriangle;
        }
    }
}
