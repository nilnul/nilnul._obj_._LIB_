using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.be
{
	public class Vow : nilnul.obj.be.Vow4<UntypedI>
		,
		untyped.VowI
	{
		public Vow(BeI1<UntypedI> be) : base(be)
		{
		}

		public Vow(Predicate<UntypedI> predicate) : base(predicate)
		{
		}

		public Vow(Func<UntypedI, bool> func) : base(func)
		{
		}
	}
}
