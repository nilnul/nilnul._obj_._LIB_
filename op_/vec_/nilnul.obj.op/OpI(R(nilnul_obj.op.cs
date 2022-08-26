using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.function;

namespace nilnul_obj.op
{
	/// <summary>
	/// An operator which returns TResult. Note the difference between Operator and Operator Expression.
	/// </summary>
	/// <typeparam name="TResult"></typeparam>
	public partial interface FunctionI<out TResult>
		: OpI
	{



	}

}

namespace nilnul_obj.op
{
	/// <summary>
	/// An operator which returns TResult. Note the difference between Operator and Operator Expression.
	/// </summary>
	/// <typeparam name="TResult"></typeparam>
	public partial interface OpI<out TResult>
		: OpI
	{


	}
}

