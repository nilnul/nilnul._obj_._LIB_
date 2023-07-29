using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.vow.ee_
{
	public class VowDefault<T, TVow>
		:
		Ee<T>
		where TVow : obj.Vow_ofRefI<(T, T)>, new()
	{
		public VowDefault(ref (T, T) val) : base(ref val,
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
		public VowDefault(T a, T b) : base(
			 (a,b),
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}

	}
}
