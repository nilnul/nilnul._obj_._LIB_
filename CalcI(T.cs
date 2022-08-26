using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public  interface CalcI<out T>
		:
		_calc_.BlankI
		,
		ICalc<T>
	{
		T calc();

	}

	public interface CalcI : CalcI<object> { }
	
}
