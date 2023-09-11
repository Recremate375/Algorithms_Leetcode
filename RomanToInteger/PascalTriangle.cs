using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	public class PascalTriangle
	{

		public IList<IList<int>> Generate(int numRows)
		{
			var triangle = new List<IList<int>>();

			if (numRows == 0) 
			{
				return triangle;
			}

			triangle.Add(new List<int> { 1 });

			for (int i = 1; i < numRows; i++)
			{
				var prevRow = (List<int>)triangle[i - 1];
				var nextRow = new List<int> { 1 };

				for (int j = 1; j < prevRow.Count; j++)
				{
					nextRow.Add(prevRow[j - 1] + prevRow[j]);
				}

				nextRow.Add(1);
				triangle.Add(nextRow);
			}

			return triangle;
		}
	}
}
