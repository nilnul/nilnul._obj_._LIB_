using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj.var.withType.expr.members;

namespace nilnul.obj.var.withType.expr
{
	/// <summary>
	/// an op call on literals as expr
	/// </summary>
	public partial class Form<T>
		:withType.expr.ExprI
		
	{


		private nilnul.obj.call.CallI<T> _call;

		public nilnul.obj.call.CallI<T> call
		{
			get { return _call; }
			set { _call = value; }
		}
		
		public Form(
			nilnul.obj.call.CallI<T> call	
		)
		{
			this._call = call;

		}

		public Form(T literal)
			:this(
				new nilnul.obj.call.Literal<T>(literal)
			)
		{
			
		}

		
	

	
		public override string ToString()
		{
			return _call.ToString();
		}

		public ExprI demote()
		{
			return new Form<T>( new call.Literal<T>( _call.eval()));

			throw new NotImplementedException();
		}

		public ExprI substitute(withType.VarI var, ExprI expr)
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI substitute(var.VarWithType var, ExprI expr)
		{
			throw new NotImplementedException();
		}
	}
}
