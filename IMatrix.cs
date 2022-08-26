using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	/// <summary>
	/// two-dimensional array.
	/// a str of vecs, each of which is of the same arity. 
	///  or a str of rows in current row by row or line by line writing convention.
	/// </summary>
	/// <remarks>
	/// The CLI spec (section 8.9.1) states:
	/// Array elements shall be laid out within the array object in row-major order(i.e., the elements associated with the rightmost array dimension shall be laid out contiguously from lowest to highest index). The actual storage allocated for each array element can include platform-specific padding.
	/// Setting up an array like this :
	/// byte[,] arr = new byte[3, 3];
	/// arr[0, 0] = 1;
	/// arr[1, 0] = 2;
	/// arr[0, 1] = 3;
	///
	/// gave me this layout in memory
	/// 01 03 00
	/// 02 00 00
	/// 00 00 00
	/// So i'm gonna assume column order
	///
	///
	///
	/// 你想想看现在计算机的基本数据结构就是一维和二维矩阵，这个基本是指物理存储结构上的基本，换句话说，是计算机的native数据结构，别的数据结构都要从上面派生/嵌入
	/// </remarks>
	/// in nilnul.num library, we might define matrix such that its dimension exceeds int.Max.
	/// But for performance, and for practical reasons (matrix, whose size exceeding int.max, cannot be run by computer as it's larger than memory), we define the matrix in line with system two-dimension array.
	///
	/// vs: IEnumerable{IEnumerable}, vec arity is lost if count is nil. but for matrix, even if rowscount is nil, col arity is still there.
	public interface IMatrix
		:
		obj.vec.IStr  ///defaulted as rowwise, i.e., each row is a vec
	{
	}

	public interface IMatrix<T> : IMatrix { }
}
