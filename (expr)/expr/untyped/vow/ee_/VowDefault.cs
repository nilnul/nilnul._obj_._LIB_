using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.untyped.vow.ee_
{
	public class VowDefault< TVow> : obj._expr.untyped.vow.Ee
		where TVow: VowI,new()
	{
		public VowDefault(Untyped val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
		public VowDefault(Expression val) : this(new Untyped(val))
		{
		}

	}
}
