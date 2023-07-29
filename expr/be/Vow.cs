using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.be
{
	public class Vow : nilnul.obj.be.Vow4<obj.ExprI4>
	{
		public Vow(BeI1<ExprI4> be) : base(be)
		{
		}

		public Vow(Predicate<ExprI4> predicate) : base(predicate)
		{
		}

		public Vow(Func<ExprI4, bool> func) : base(func)
		{
		}
	}
}
