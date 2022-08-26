using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_
{
	public class Clone<T>
		: UnaryI<T>
	{
		static public  T[,] Op(in T[,] matrix)
		{
			var rows = matrix.GetLength(0);
			var cols = matrix.GetLength(1);
			var r= new T[rows,cols ];

			//ref T[,] r=ref t ;
			for (int i = 0; i < rows;i++ )
			{
				for (int j = 0; j < cols; j++) {
					r[i, j] = matrix[i, j];
				}
			}
			return  r;

		}

		public T[,] op( T[,] matrix)
		{
			return Op(in matrix);

		}

		static public Clone<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Clone<T>>.Instance;
			}
		}

	}
}
