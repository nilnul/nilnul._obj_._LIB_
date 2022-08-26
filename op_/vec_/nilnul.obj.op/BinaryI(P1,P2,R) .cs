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
	public partial interface BinaryI<in P0,in P1,out R> 
		:OpI<R>
		
	{
		R eval(P0 x,P1 y);
	}
}
