using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func_.closed_.generi.vow
{
	public class Ee<TRet>
		:
		nilnul.obj.vow.Ee1<
			obj.func_.closed_.Generi<TRet>
			,
			func_.closed_.generi.VowI<TRet>
		>
	{
		public Ee(func_.closed_.Generi<TRet> val, VowI<TRet> vow) : base(val, vow)
		{
		}
	}
}
