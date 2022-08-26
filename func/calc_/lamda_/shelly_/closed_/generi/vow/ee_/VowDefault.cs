using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.closed_.generi.vow.ee_
{
	public class VowDefault<TRet, TVow>
		: Ee<TRet>
		where TVow : func.calc_.lamda_.closed_.generi.VowI<TRet>, new()
	{
		public VowDefault(func.calc_.lamda_.closed_.Generi<TRet> val)
			:
			base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
	}
}
