using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.expr_
{
	/// <summary>
	/// in math, we might use f(x)=x such that f is a var standing for x=>x.
	/// </summary>
	/// 
	public class Var :
		obj.expr_.typed_.generi_.Var<obj.FuncI3>
		,
		VarI

	{
		public Var()
		{
		}

		public Var(ParameterExpression val) : base(val)
		{
		}

		public Var(string s) : base(s)
		{
		}
	}
}
