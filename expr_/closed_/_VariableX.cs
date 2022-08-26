using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr_.closed_
{

	static public class _VariableX
	{
		static public TExpr Substitute<T, TVariable,TVar,TExpr>(this TExpr expr, TVar subVar,TExpr subExpr)
			where TVariable:_variable_.VarI<TVar>
			where TVar: nilnul.obj.VarI6<T>

		{
			if (object.ReferenceEquals( expr.var ,subVar ))
			{
				return subExpr;

			}
			return expr;	//not implementable as TVar:Texpr fails
		}

	}





}
