using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix._grid.mosaic.be_
{

	/// <summary>
	/// 
	/// </summary>
	static public class _PartitionedX
	{
		static public bool _IsPartitioned_assumeDwelt<T>(this T[,][,] grid)
		{

			for (int i = 0; i < grid.GetLength(0); i++)
			{

				var h = grid[i, 0].GetLength(0);
				for (int j = 1; j < grid.GetLength(1); j++)
				{
					if (grid[i, j].GetLength(0) != h) { return false; }
				}

			}
			for (int i = 0; i < grid.GetLength(1); i++)
			{
				var w = grid[0, i].GetLength(1);
				for (int j = 1; j < grid.GetLength(0); j++)
				{

					if (grid[i, j].GetLength(1) != w) { return false; }

				}
			}

			return true;
		}
		static public bool IsPartitioned<T>(this T[,][,] grid)
		{

			if (obj.matrix.be_._EmptyX.IsEmpty(grid) )
			{ ///todo: this is fishy, we need to check for c# syntax whether it would allow the component's dimension to be set, even it's empty; it seems not as we can declare the type as : doulbe[,][,] sans the lengths.
				return true;
			}
			return _IsPartitioned_assumeDwelt(grid);

		}
	}
}
