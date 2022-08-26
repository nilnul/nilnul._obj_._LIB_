using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re.co.or_
{
	public class ReDefault<TObj, TRe, TRe1>
		:
		obj.re.co.Or<TObj>
		where TRe : obj.ReI<TObj>, new()
		where TRe1 : obj.ReI<TObj>, new()

	{
		public ReDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRe>.Instance
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TRe1>.Instance

		)
		{
		}
	}
}
