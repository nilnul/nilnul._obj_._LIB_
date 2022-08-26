using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be
{
	public class Vow<T> : nilnul.obj.be.Vow4<obj.ExprI_sys<T>>
	{
		public Vow(BeI1<ExprI_sys<T>> be) : base(be)
		{
		}

		public Vow(Predicate<ExprI_sys<T>> predicate) : base(predicate)
		{
		}

		public Vow(Func<ExprI_sys<T>, bool> func) : base(func)
		{
		}
	}
}
