using nilnul.obj.expr._stati;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	/// <summary>
	/// unbrella for expr of type T
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface StatiI< out T>

		:StatiI
		,_stati.ReduceI<T>, _stati.SubstituteI<T>,_stati.VarsI
	{


	}

	public interface StatiI:ExprI_blank1
		//,nilnul.obj.call._call.OpI
	{


	}


}
