using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_
{
	public class Col<T>
		:
		obj.matrix.vow.ee_.VowNeo<T, matrix.be_.col.Vow<T>>
	{
		public Col(T[,] val) : base(val)
		{
		}
	}
}
