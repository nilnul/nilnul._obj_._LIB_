using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.typed_.generi.vow.ee_
{
	public class VowDefault<TRet, TVow>
		: Ee<TRet>
		where TVow : func_.typed_.generi.VowI<TRet>, new()
	{
		public VowDefault(func_.typed_.Generi<TRet> val)
			:
			base(val, nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TVow>.Instance)
		{
		}
	}
}
