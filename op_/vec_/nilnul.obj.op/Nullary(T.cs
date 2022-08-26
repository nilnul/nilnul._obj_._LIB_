using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op
{
	/// <summary>
	/// Given T, there are #T of constant functions.
	/// </summary>
	public  class Nullary< T>
		:OpI<T>
	{
		private T _result;

		public T result
		{
			get { return _result; }
			set { _result = value; }
		}
		

		public Nullary(T result)
		{
			this.result = result;
		}

		public T eval() {

			return _result;
		
		}

		public class Const
			:Call_OpA<Nullary<T>>
			,
			CallI<T>
		{
			public Const(Nullary<T> op)
				:base(op)
			{

			}


			public T eval()
			{
				return op.eval();
				throw new NotImplementedException();
			}
		}

		public class Expr
			:Call_OpA<Nullary<T>>
		{

			public Expr(Nullary<T> op)
				:base(op)
			{

			}


			public T eval()
			{
				return op.eval();
				throw new NotImplementedException();
			}


		}



		


	}
}
