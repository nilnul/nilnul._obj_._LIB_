using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.closed.be
{

	public class Vow
		:
		nilnul.obj.be.Vow4<
			func.calc_.lamda_.Closed
		>
		,
		func.calc_.lamda_.closed.VowI
	{
		public Vow(BeI1<func.calc_.lamda_.Closed> be) : base(be)
		{
		}

		public Vow(Predicate<func.calc_.lamda_.Closed> predicate) : base(predicate)
		{
		}

		public Vow(Func<func.calc_.lamda_.Closed, bool> func) : base(func)
		{
		}
	}
}
