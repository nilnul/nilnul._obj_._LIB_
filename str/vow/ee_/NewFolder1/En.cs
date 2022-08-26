using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.vow.ee_
{

	[Obsolete()]
	public class VowDefault<T, TStr, TVow>
		: nilnul.obj.str.vow.Ee<T, TStr>
		where TVow : nilnul.obj.str.VowI1<T, TStr>, new()
		where TStr : nilnul.obj.StrI2<T>
	{
		public VowDefault(TStr val) : base(val, nilnul.obj_.singleton_.Lazy<TVow>.Instance)
		{
		}
	}

}
