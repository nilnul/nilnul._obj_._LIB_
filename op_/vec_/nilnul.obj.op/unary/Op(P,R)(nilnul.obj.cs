using nilnul_obj.op;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op.unary
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Op<P,R>
		:UnaOpI<P,R>
	{
		System.Func<P, R> op;


		public Op(System.Func<P, R> op)
		{
			this.op = op;
		}


		public R eval(P a)
		{
			throw new NotImplementedException();
		}
	}
}
