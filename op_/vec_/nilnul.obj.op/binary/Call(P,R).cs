using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.binary
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Call<P,P1,R>

			:obj.op.Call_OpArgArg1A<BinaryI<P,P1,R>,CallI<P>,CallI<P1>>
		,
		op.CallI<R>
		{

			public Call(
				BinaryI<P,P1,R> op
				,
				CallI<P> arg
				,CallI<P1> arg1
				
				)
				:base(op,arg,arg1)
			{

			}

			public R eval()
			{
				return op.eval( arg.eval(),arg1.eval());

				throw new NotImplementedException();
			}
		}
	
}
