using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.co.be
{
	public class Vow<T>
		: nilnul.obj.co.be.vow_.OfIn<T[,]>
		,
		matrix.co.VowI<T>

	{
		public Vow(in BeI_ofIn<(T[,], T[,])> val) : base(val)
		{
		}

		public Vow(BeI_ofIn<(T[,], T[,])> x) : base(x)
		{
		}
	}
}
