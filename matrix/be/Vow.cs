using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.matrix.be
{
	public class Vow<T>
		: nilnul.obj.be.Vow4<T[,]>
		,
		matrix.VowI<T>
	{
		public Vow(BeI1<T[,]> be) : base(be)
		{
		}

		public Vow(Predicate<T[,]> predicate) : base(predicate)
		{
		}

		public Vow(Func<T[,], bool> func) : base(func)
		{
		}
	}
}
