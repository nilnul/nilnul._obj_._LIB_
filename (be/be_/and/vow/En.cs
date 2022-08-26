using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.be_.and.vow
{
	public class En<TObj, TBe, TBe1>
		: nilnul.obj.vow.En<
			TObj
			,
			be_.and.Vow<TObj, TBe, TBe1>
		>
		where TBe : nilnul.obj.BeI1<TObj>, new()
		where TBe1 : nilnul.obj.BeI1<TObj>, new()
	{
		public En(TObj val) : base(val)
		{
		}
	}
}
