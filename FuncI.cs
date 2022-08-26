using nilnul.obj._func.lamda.be_.flat.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace nilnul.obj
{
	
	/// <summary>
	/// the taxonomy of func classifies according to func's return type
	/// </summary>
	public interface FuncI3
		:_func_.FlatI
		,
		IFunc
	{
		
	}

	public class Func3 :
		_func.lamda.be_.flat.vow.Ee
		,
		FuncI3
	{
		public Func3(LambdaExpression val) : base(val)
		{
		}

		public Ee flat => this;

		static public Func3 OfExpr(obj.ExprI4 expr) {

			return new Func3(
				LabelExpression.Lambda(expr.expr.ee)
			);
		}
	}




}