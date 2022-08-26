using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni_.closed.vow.ee_
{
	public class VowDefault< TVow>
		: Ee
		where TVow : func.calc_.lamda_.uni_.closed.VowI, new()
	{
		public VowDefault(func.calc_.lamda_.uni_.Closed val)
			:
			base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
	}
}
