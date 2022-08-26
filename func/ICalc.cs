using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func
{
	/// <summary>
	/// a calculation of func.
	/// </summary>
	/// <remarks>
	/// vs:func
	///		func is one-level abstraction. the body of the func cannot be func.
	///		func.Calc is arbitrary-leveled abstraction. the body of the calc is always a calc as the 0-layer calc's body is itself.
	///		func.Calc is corresponding to <see cref="System.Linq.Expressions.LabelExpression"/>
	///		func is corresponding to <see cref="_func.lamda.be_.flat.vow.Ee"/>
	///		a calc can be uncurried to multivarite func.
	///
	/// this doesnot involve func.expr_.Var
	///
	/// 	it's meaningful to differ <see cref="CalcI"/> from <see cref="IFunc"/>, cuz in calc, the body might still be a function, and when the pars are used up, we shall use the pars of the body. for func, we look for pars no further than before the body
	/// </remarks>
	public interface ICalc
		:nilnul.obj.ICalc<obj.IFunc>
	{

	}


}
/*
A lambda expression doesn't have a type. It cannot, because any type in the .NET world that it could have, would also hard-code the type of the lambda's parameters and result. Now consider:
()=>0
x => x + 1
(x,y) =>(x+y)   // it might be string concat.
What type could x have? What type will the result be? There isn't any single answer, and the lambda expression can indeed be converted to Func<int, int>, Func<double, double>, and many other delegate types with different parameters. Giving a lambda expression a type would disallow such expressions. C# did want to allow such expressions, so was designed not to give such expressions any type.
*/