using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// <remarks>
	/// this is a morphism so that the domain is on the left and the codomain is on the right.
	/// 
	/// </remarks>
	public partial interface TernaryI<in P,in P1,in P2,out R> 
		:OpI<R>
		,TernaryI
		
	{
		R eval(P x,P1 y,P2 z);
	}
}
