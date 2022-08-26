using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Unary<P,R>
		:UnaryI<P,R>
	{
		System.Func<P, R> op;


		public Unary(System.Func<P, R> op)
		{
			this.op = op;
		}



		public R eval(P a)
		{
			return op(a);
			throw new NotImplementedException();
		}



		public class Expr
			:ExprI2<R>
		{
			private ExprI2<P> _arg;

			public ExprI2<P> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}

			private UnaryI<P,R> _op;

			public UnaryI<P,R> op
			{
				get { return _op; }
				set { _op = value; }
			}





			public R eval()
			{
				return op.eval(arg.eval());

				throw new NotImplementedException();
			}
		}

		public class Const
			:Call_OpArgA<Unary<P,R>,P>
			,CallI<R>
		{

			public Const(Unary<P,R> op,P arg)
				:base(op,arg)
			{

			}

			public R eval() {
				return op.eval(arg);
			}

		}

		public class Expr2
			:Call_OpArgA<Unary<P,R>,RefI<P>>

		{
			public Expr2(Unary<P,R> op, RefI<P> arg)
				:base(op,arg)
			{

			}



		}

	}
}
