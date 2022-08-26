using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call
{
	public partial class Binary<P,P1,R>
		:nilnul.obj.call.BiOpArgArg1A<
			nilnul.obj.op.BinaryI<P,P1,R>
			,
			nilnul.obj.call.CallI<P>
			,
			nilnul.obj.call.CallI<P1>
		>,
		CallI<R>
	{


		public Binary( 			
			nilnul.obj.op.BinaryI<P,P1,R> op
			,
			nilnul.obj.call.CallI<P> arg
			,
			nilnul.obj.call.CallI<P1> arg1
		):base(op,arg,arg1)
		{


		}
		public R eval()
		{
			return op.eval(arg.eval(), arg1.eval());
			throw new NotImplementedException();
		}

	
	}
}
