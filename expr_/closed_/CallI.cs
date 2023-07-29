using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.closed_
{
	/*
	 * Niladic
The method contains no arguments, this one can be easy understand, for example, Java’s ‘ToString()’ method

Monadic
The method contains a single argument. Java’s base class Object#equals(Object obj)

Dyadic
A method with 2 arguments, for example the String method replace……. replace(char oldChar, char newChar).

Triadic

Method with 3 arguments
Example StringBuffer’s replace method…. replace(int start, int end, String str)


Polyadic
A method that for some reason has more than 3, such as the String method ‘regionMatches’ which can be confusing to know which order the arugments come in (without looking at the doc)*/
	/// <summary>
	/// involving only <see cref="obj.IOp"/>s, recursively;
	/// </summary>
	public interface ICall {

	}

	/// <summary>
	/// var or call_.
	/// </summary>
	public interface CallI<T, TVar, TVars, TExpr>
		:
		nilnul.obj.expr_.ClosedI<T, TVar, TVars, TExpr>
		where TVar : nilnul.obj.VarI6<T>
		where TVars : nilnul.obj.var.SetI2<T, TVar>
		where TExpr : nilnul.obj._expr_.VarsI<TVars>
					,nilnul.obj.expr_.ClosedI<T,TVar,TVars,TExpr>

	{
	}


	/// <summary>
	/// var or call_.
	/// </summary>
	public interface CallI<T> : nilnul.obj.expr_.ClosedI<T>
	{
	}


}
