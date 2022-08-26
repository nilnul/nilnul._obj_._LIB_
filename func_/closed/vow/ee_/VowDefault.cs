using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.closed.vow.ee_
{
	public class VowDefault< TVow>
		: Ee
		where TVow : func_.closed.VowI, new()
	{
		public VowDefault(func_.Closed val)
			:
			base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
	}
}
