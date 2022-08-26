using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call.op.unary
{
	public partial class Call<P,R>
		:nilnul.obj.op.Call_OpArgA<
			nilnul.obj.op.UnaryI<P,R>
			,
			nilnul.obj.call.CallI<P>
		>,
		CallI<R>
	{


		public Call( 			
			nilnul.obj.op.UnaryI<P,R> op
			,
			nilnul.obj.call.CallI<P> arg
		):base(op,arg)
		{


		}
		public R eval()
		{
			return op.eval(arg.eval());
			throw new NotImplementedException();
		}
	}
}
