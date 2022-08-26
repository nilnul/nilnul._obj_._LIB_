using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.closed.be
{

	public class Vow
		:
		nilnul.obj.be.Vow4<
			func_.Closed
		>
		,
		func_.closed.VowI
	{
		public Vow(BeI1<func_.Closed> be) : base(be)
		{
		}

		public Vow(Predicate<func_.Closed> predicate) : base(predicate)
		{
		}

		public Vow(Func<func_.Closed, bool> func) : base(func)
		{
		}
	}
}
