using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re
{
	public class Co<TObj> : nilnul.obj.Co<nilnul.obj.ReI<TObj>>
	{
		public Co(Tuple<ReI<TObj>, ReI<TObj>> tuple) : base(tuple)
		{
		}

		public Co((ReI<TObj>, ReI<TObj>) valTuple) : base(valTuple)
		{
		}

		public Co(ReI<TObj> item1, ReI<TObj> item2) : base(item1, item2)
		{
		}
	}
}
