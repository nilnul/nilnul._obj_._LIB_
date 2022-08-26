using System;
using System.Collections.Generic;
using System.Net;

namespace nilnul.obj.op.nullary
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// 
	[Obsolete("nilnul.obj.op.Nullary")]
	public partial class Const2<T> 
		:OpI< T>
	{
		public T val;

		public Const2(T val)
		{
			this.val = val;
		}
	

		public T eval()
		{
			return val;
		}


		public class Call
			:
			
			op.CallI<T>
		{
			private op.nullary.Const2<T> _op;

			public op.nullary.Const2<T> op
			{
				get { return _op; }
				set { _op = value; }
			}
			
			public Call(op.nullary.Const2<T> op)
			{
				this.op = op;
			}

			public T eval()
			{
				return op.eval();
				throw new NotImplementedException();
			}
		}

		public class Expr
			:
			ExprI2<T>
			,ExprI3<T>
		{
			private Const2<T> _op;

			public Const2<T> op
			{
				get { return _op; }
				set { _op = value; }
			}
			
			public Expr(Const2<T> op)
			{
				this.op = op;
			}
			public Expr(T arg)
				:this(new Const2<T>(arg))
			{
			}

			public T eval() {
				return op.eval();
			}

			static public implicit operator T(Expr  a)
			{
				return a.eval();
			}
			static public implicit operator Expr(T a)
			{
				return new Expr(a);
			}




			
		}
		





	}


	
}
