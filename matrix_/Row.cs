using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix_
{
	public class Row<T>
		:
		obj.matrix.vow.ee_.VowNeo<T, matrix.be_.row.Vow<T>>
	{
		public Row(T[,] val) : base(val)
		{
		}
	}
}
