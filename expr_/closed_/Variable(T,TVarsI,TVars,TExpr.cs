using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr_.closed_
{

	public abstract class VariableA<T, TVar, TVarsI, TVars, TExpr>
		: nilnul.obj.Box1<TVar>
		,
		_closed_.VarsI<TVarsI>
		,
		_closed_.SubstituteI<TVar,TExpr>

		where TVar : nilnul.obj.VarI6<T>
		where TVarsI : nilnul.obj.var.SetI2<T, TVar>
		where TVars : TVarsI, new()
		where TExpr : _closed_.SubstituteI<TVar, TExpr>, _closed_.VarsI<TVarsI>
		,
		IClosed<T>
		//:TExpr  //fails
	{
		public VariableA(TVar val) : base(val)
		{
		}

		public TVarsI vars => new TVars();

		public abstract TExpr substitute(TVar var, TExpr expr);


		//static public TExpr Substitute( TVar var, TExpr expr)
		//{
		//	if (this.boxed==var)
		//	{
		//		return expr;
		//	};
		//	return this;
		//}
	}






}
