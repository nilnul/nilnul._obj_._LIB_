using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs.vow.ee_
{

	[Obsolete()]

	public class VowDefault<T, TStr, TVow>
		: nilnul.objs.vow.Ee<T, TStr>
		where TVow : nilnul.objs.VowI1<T, TStr>, new()
		where TStr : nilnul.ObjsI3<T>
	{
		public VowDefault(TStr val) : base(
			val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
			)
		{
		}
	}

	public class VowDefault<T,  TVow>
		: nilnul.objs.vow.Ee<T>
		where TVow : nilnul.objs.VowI1<T>, new()
	{
		public VowDefault(nilnul.ObjsI3<T> val) : base(
			val
			,
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance
		)
		{
		}
	}

}
