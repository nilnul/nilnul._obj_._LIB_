using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.recur_
{
	public class OpDefault<T, TOp>
		:
		Recur<T, TOp>
		where
		TOp : op_.UnaryI<T>, new()

	{
		public OpDefault(T initial0) : base(
			initial0
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TOp>.Instance
		)
		{
		}
	}
}
