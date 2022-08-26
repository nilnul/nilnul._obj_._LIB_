using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be_.square.vow
{
	[Obsolete()]
	public class En<T>
	{

		private T[,] _matrix;

		public T[,] matrix
		{
			get { return _matrix; }
			//set { _matrix = value; }
		}

		public En(T[,] matrix)
		{
			Vow.Singleton.vow(matrix);
			_matrix = matrix;
		}
	}
}
