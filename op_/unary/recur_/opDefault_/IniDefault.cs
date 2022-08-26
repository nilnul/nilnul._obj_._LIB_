using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.unary.recur_.opDefault_
{
	public class IniDefault<T, TOp>
		:
		OpDefault<T, TOp>
		where
		TOp : op_.UnaryI<T>, new()
		where T: new()

	{
		public IniDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<T>.Instance
			
		)
		{
		}
	}
}
