using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	public abstract partial class CompoA<TInVar,TRet,TInExpr>
	{

		void compo<TRet_arg>(
			FuncI<TInExpr, TRet_arg> func
		);
			


	}
}
