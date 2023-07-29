using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._expr.expr0lamda.vow.ee_
{
	public class VowDefault< TVow> : obj._expr.expr0lamda.vow.Ee
		where TVow: VowI,new()
	{
		public VowDefault(Expression val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
