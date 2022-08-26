using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.function;

namespace nilnul_obj.op
{
	public partial class UnaOpConst<P,R, A>
		:
		UnaOpCallA<A,UnaOpI<P,R>>

		where A:ConstI<P>

	{

		
		public UnaOpConst( UnaOpI<P,R> op,A operand)
			:base(operand,op)
		{
			
			

		}






	}
}
