using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi.be
{
	public class Vow<T> : nilnul.obj.be.Vow4<obj.expr_.typed_.GeneriI<T>>
	{
		public Vow(BeI1<GeneriI<T>> be) : base(be)
		{
		}

		public Vow(Predicate<GeneriI<T>> predicate) : base(predicate)
		{
		}

		public Vow(Func<GeneriI<T>, bool> func) : base(func)
		{
		}
	}
}
