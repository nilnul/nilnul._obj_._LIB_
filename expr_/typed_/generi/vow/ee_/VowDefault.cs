using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi.vow.ee_
{
	//[Obsolete()]
	public class VowDefault<T, TVow> : obj.expr_.typed_.generi.vow.Ee<T>
		where TVow: VowI2<GeneriI<T>>,new()
	{
		public VowDefault(GeneriI<T> val) : base(val, nilnul.obj_.Singleton<TVow>.Instance)
		{
		}
	}
}
