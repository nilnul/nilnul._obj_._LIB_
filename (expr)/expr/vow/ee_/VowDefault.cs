using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.vow.ee_
{
	public class VowDefault< TVow> : obj.expr.vow.Ee
		where TVow: VowI2<ExprI4>,new()
	{
		public VowDefault(ExprI4 val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
