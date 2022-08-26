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
	public partial class Binary<P,P1,R>

		:NameA
		,
		BinaryI<P,P1,R>
		
	{
		Func<P,P1, R> op;


		public Binary(Func<P,P1,R> op)
		{
			this.op = op;
		}

		public Binary(Func<P,P1,R> op,string name)
		{
			this.op = op;
			this.name = name;
		}



		public R eval(P a,P1 b)
		{
			return op(a,b);
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


			private ExprI2<P1> _arg1;

			public ExprI2<P1> arg1
			{
				get { return _arg1; }
				set { _arg1 = value; }
			}
			
			private BinaryI<P,P1,R> _op;

			public BinaryI<P,P1,R> op
			{
				get { return _op; }
				set { _op = value; }
			}





			public R eval()
			{
				return op.eval(arg.eval(),arg1.eval());

				throw new NotImplementedException();
			}
		}

		public class Expr2
			:
			Call_OpArgArg1A<BinaryI<P,P1,R>,ExprI3<P>,ExprI3<P1>>
			,
			ExprI3<R>
		{

			public Expr2(BinaryI<P,P1,R> op,ExprI3<P> p1,ExprI3<P1> arg2 )
				:base(op,p1,arg2)
			{
			}
	
		}

		public class Const:
			Call_OpArgArg1A<BinaryI<P,P1,R> ,ConstI<P>,ConstI<P1>>
			,ConstI<R>
		{

			public Const(
				BinaryI<P,P1,R> op
				,
				ConstI<P> arg
				,ConstI<P1> arg1
				
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
}
