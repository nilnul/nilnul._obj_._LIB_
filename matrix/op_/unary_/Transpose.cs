using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.op_.unary_
{
	public class Transpose<T>
		: UnaryI<T>
	{
		public T[,] op(T[,] matrix)
		{
			return matrix.Transpose();

		}


		static public Transpose<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Transpose<T>>.Instance;
			}
		}

	}
}
