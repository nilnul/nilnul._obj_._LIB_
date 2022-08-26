using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr.vow.ee_
{
	public class VowDefault<T, TVow> : obj.expr.vow.Ee<T>
		where TVow: VowI2<ExprI_sys<T>>,new()
	{
		public VowDefault(ExprI_sys<T> val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
