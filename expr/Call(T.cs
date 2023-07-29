using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr
{
	/// <summary>
	/// an op call on literals as expr
	/// </summary>
	///
	[Obsolete(nameof(expr.ICalculation))]

	public class Call<T>
		:CallI<T>
		
	{


		private nilnul.obj.call.CallI<T> _call;

		public nilnul.obj.call.CallI<T> call
		{
			get { return _call; }
			set { _call = value; }
		}
		
		public Call(
			nilnul.obj.call.CallI<T> call	
		)
		{
			this._call = call;

		}

		public Call(T literal)
			:this(
				new nilnul.obj.call.Literal<T>(literal)
			)
		{
			
		}

		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="V"></typeparam>
		/// <param name="var"></param>
		/// <param name="expr"></param>
		/// <returns></returns>
		public ExprI<T> substitute<V>(VarI3<V> var, ExprI<V> expr)
		{

			return this;

			throw new NotImplementedException();
		}

	

		public ExprI<T> demote()
		{
			return new Call<T>( new call.Literal<T>( _call.eval()));
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return _call.ToString();
		}



		
	}
}
