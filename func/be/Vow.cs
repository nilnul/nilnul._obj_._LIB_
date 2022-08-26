using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;

namespace nilnul.obj.func.be
{

	public class Vow
		:
		nilnul.obj.be.Vow4<
			obj.FuncI3
		>
		,
		func.VowI
	{
		

		public Vow(BeI1<obj.FuncI3> be) : base(be)
		{
		}

		public Vow(Predicate<obj.FuncI3> predicate) : base(predicate)
		{
		}

		public Vow(Func<F, bool> func) : base(func)
		{
		}
	}
}
