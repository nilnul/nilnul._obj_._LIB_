using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.shuffle_
{

	/// <summary>
	/// columnwise shuffle
	/// </summary>
	static public  class _ColwiseX
	{
		static public unsafe void  _Act_assumeValid<T>(in T[,] m, in int i, in int j){
			var rows = m.GetLength(0);

			for (int r = 0; r < rows; r++)
			{
				(m[r,i], m[r, j]) = (m[r,j],m[r,i]);
			}
		}
	}
}
