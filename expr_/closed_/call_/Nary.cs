using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.closed_.call_
{
	public interface INary { }

	public interface NaryI<T>
		:
		closed_.CallI<T>
		,
		INary
	{

	}

	public abstract class NaryA<T,TVar,TVarsI,TVars, TExpr, TOp> :

		nilnul.obj.calc_._nary.Op<TOp>
		,
		nilnul.obj.expr_.closed_.CallI<T,TVar,TVarsI,TExpr>

		where TOp : nilnul.obj.op_.NaryI<T>
		where TVar: nilnul.obj.VarI6<T>
		where TVarsI: nilnul.obj.var.SetI2<T,TVar>
		where TVars:TVarsI,new()
		where TExpr: nilnul.obj.expr_.ClosedI<T,TVar,TVarsI,TExpr>

	{
		public NaryA(TOp op) : base(op)
		{
		}

		public  TVarsI vars { get { return new TVars(); } }

		public abstract TExpr substitute(TVar var, TExpr expr);
		//{
		//	return this;
		//}
	}

	public class Nary<T>
		: NaryA<T, nilnul.obj.VarI6<T>, nilnul.obj.var.SetI2<T>, nilnul.obj.var.Set2<T>, expr_.ClosedI<T>, nilnul.obj.op_.NaryI<T>>
		,
		expr_.closed_.CallI<T>
		,
		NaryI<T>
		

	{
		public Nary(nilnul.obj.op_.NaryI<T> op) : base(op)
		{
		}

		public Nary(
			T literal
		):this(
			new nilnul.obj.op_.Nary<T>(literal)
		)
		{

		}

		//public override var.SetI<T> vars => new var.Set<T>();

		public override ClosedI<T> substitute(nilnul.obj.VarI6<T> var, ClosedI<T> expr)
		{
			return this;
			;
		}
	}



}
