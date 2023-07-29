using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.op_;

namespace nilnul.obj.calc_
{
	public  interface UnaryI<R,TArg, TOp>
		:nilnul.obj._call_.OpI1<TOp>
		,
		nilnul.obj.calc_._unary.ArgI<TArg>
		,
		CalcI<R>
		where TOp: nilnul.obj.op_.UnaryI<R>
		where TArg:CalcI<R>
	{

		
	}

	public interface UnaryI<R>
		:UnaryI<R, obj.CalcI<R>, obj.op_.UnaryI<R> >
	{ }

}
