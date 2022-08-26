using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.distinct.vow
{
	[Obsolete()]
	public class Ed<T, TStr> : nilnul.obj.vow.Ed<TStr>
		where TStr : nilnul.obj.StrI<T>
	{
		public Ed( IEqualityComparer<T> eq, TStr val) : base(val, new nilnul.obj.str.be_.distinct.Vow_str<T,TStr>(eq))
		{
		}
	}
}
