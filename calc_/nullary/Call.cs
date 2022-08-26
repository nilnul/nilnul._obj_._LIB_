using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.call.op.nullary
{
	public partial class Call<R>
		:nilnul.obj.op.Call_OpA<
			nilnul.obj.op.NullaryI<R>
		>,
		CallI<R>
	{

		public Call( 			
			nilnul.obj.op.NullaryI<R> op
		):base(op)
		{


		}


		public Call(
			R val
		)
			:base( new obj.op.Nullary2<R>(val))
		{

		}
		public R eval()
		{
			return op.eval();
			throw new NotImplementedException();
		}
	}
}
