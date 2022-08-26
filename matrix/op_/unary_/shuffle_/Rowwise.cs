using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_.shuffle_
{

	/// <summary>
	/// rowwise shuffle
	/// </summary>
	static public  class _RowwiseX
	{
		static public unsafe void  _Act_assumeValid<T>(in T[,] m, in int i, in int j){
			var cols = m.GetLength(1);

			for (int u = 0; u < cols; u++)
			{
				(m[i, u], m[j, u]) = (m[j,u],m[i,u]);
			}
		}
	}
}
