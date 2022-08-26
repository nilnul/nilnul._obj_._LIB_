using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix
{
	/// <summary>
	/// a matrix partitioned by vertical and horizontal thru lines, to a matrix of matrixes.
	/// </summary>
	/// <remarks>
	/// each component is called block/tile
	/// </remarks>
	/// alias:
	///		grid
	///		mosaic
	///			matrix of matrix,
	///				but component might be of various size, and might be not grid
	///		block matrix
	///		partition
	///		arrangement
	///		assort
	///		tiling
	///		tabulo
	public interface IGrid
		:
		_grid.IMosaic
	{
	}

	public interface IGrid<T> : IGrid,_grid.IMosaic<T> { }
}
