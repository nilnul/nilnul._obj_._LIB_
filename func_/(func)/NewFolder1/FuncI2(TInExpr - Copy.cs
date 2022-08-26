using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public  interface FuncI2<TPar, TBody>
		:
		_func_.ParsI<TPar>
		,
		_func_.BodyI<TBody>
		where TPar:nilnul.obj.var._sortie_.BlankI
		where TBody:nilnul.obj._expr_.BlankI
	{
		
	}
}
