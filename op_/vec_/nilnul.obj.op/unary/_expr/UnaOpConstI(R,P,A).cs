using System;
using System.Collections.Generic;
using System.Text;
using nilnul_obj.function;

namespace nilnul_obj.op
{
	/// <summary>
	///  Op is Op(P,R).
	/// A is ConstI(P)
	/// itself is ConstI(R)
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A"></typeparam>
	/// 
	public partial interface UnaOpConstI<P, R, A> : ConstI<R>, UnaOpExprI<P, R, A>

		where A:ConstI<P>

	{
		
	}
}
