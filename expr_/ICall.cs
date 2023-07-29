using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_
{
	/// <summary>
	/// analog to <see cref="obj.ICalc"/>|<see cref="obj.ICall"/>, which is of <see cref="obj.IOp"/>, but here we use <see cref="obj.IExpr"/> as the 
	/// <see cref="nameof(System.Linq.Expressions.MethodCallExpression)"/>
	/// 
	/// </summary>
	/// alias:
	///		call
	///		oped
	public interface ICall
		:
		obj.expr.ICalculation
	{
	}

	
}
