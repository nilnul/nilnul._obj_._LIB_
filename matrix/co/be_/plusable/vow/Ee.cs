using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.co.be_.plusable.vow
{
	public class Ee<T>
		:
		matrix.co.vow.ee_.VowNeo<T, Vow<T>>
	{
		public Ee(in (T[,], T[,]) val) : base(val)
		{
		}
		public Ee((T[,], T[,]) val) : base(val)
		{
		}


		public Ee(in T[,] x, in T[,] y) : base(x, y)
		{
		}

		public Ee(in T[,] x, T[,] y) : base(x, y)
		{
		}

		public Ee(T[,] x, in T[,] y) : base(x, y)
		{
		}

		public Ee(T[,] x, T[,] y) : base(x, y)
		{
		}
	}
}
