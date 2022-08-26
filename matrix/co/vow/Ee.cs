using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.co.vow
{
	public class Ee<T>
		:
		nilnul.obj.co.vow.Ee_ofIn<T[,]>
	{
		

		public Ee(in (T[,], T[,]) val, in VowI_ofIn<(T[,], T[,])> vow) : base(val, vow)
		{
		}

		public Ee(in (T[,], T[,]) val, VowI_ofIn<(T[,], T[,])> vow) : base(val, vow)
		{
		}

		public Ee((T[,], T[,]) val, in VowI_ofIn<(T[,], T[,])> vow) : base(val, vow)
		{
		}

		public Ee((T[,], T[,]) val, VowI_ofIn<(T[,], T[,])> vow) : base(val, vow)
		{
		}

		public Ee(T[,] x, T[,] y, in VowI_ofIn<(T[,], T[,])> vow) : base(x, y, vow)
		{
		}

		public Ee(T[,] x, T[,] y, VowI_ofIn<(T[,], T[,])> vow) : base(x, y, vow)
		{
		}

		public Ee(in T[,] x, in T[,] y, in VowI_ofIn<(T[,], T[,])> vow) : base(x, y, vow)
		{
		}

		public Ee(in T[,] x, T[,] y, in VowI_ofIn<(T[,], T[,])> vow) : base(x, y, vow)
		{
		}

		public Ee(T[,] x, in T[,] y, VowI_ofIn<(T[,], T[,])> vow) : base(x, y, vow)
		{
		}
	}
}
