using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._expr;
using nilnul.obj._expr._members;
using nilnul.obj._var;
using nilnul.obj.var.set;

namespace nilnul.obj.expr.duo
{
	public partial class Call<P, P1, R>
		:
		nilnul.obj.duo.CallA<obj.duo.op.OpI<P, P1, R>, _expr.ExprI_dynamic,_expr.ExprI_dynamic>
		,
		ExprI_dynamic
	{
		public Type type
		{
			get
			{
				return typeof(R);
				throw new NotImplementedException();
			}
		}

		public HashSet<_var.VarI_dynamicTyped> vars
		{
			get
			{
				var r = arg.vars;
				r.UnionWith(arg1.vars);
				return r;
				throw new NotImplementedException();
			}
		}

		public Call(
			obj.duo.op.OpI<P, P1, R> op
			,
			_expr.ExprI<P> arg
			,
			_expr.ExprI<P1> arg1
		)
			: base(op, arg, arg1)
		{

		}

		public Call(
			obj.duo.op.OpI<P, P1, R> op
			,
			_expr.ExprI_dynamic arg
			,
			_expr.ExprI_dynamic  arg1
		)
			: base(op, arg, arg1)
		{
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg.type, typeof(P));
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg1.type, typeof(P1));

		}

		public Call(
			obj.duo.op.OpI<P, P1, R> op
			,
			_var.VarI_dynamicTyped arg
			,
			_var.VarI_dynamicTyped arg1
		)
			: base(op,
				  new _expr.Var(arg)
				  , 
				  new _expr.Var(arg1)
				  )
		{
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg.type, typeof(P));
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg1.type, typeof(P1));

		}

		public Call(
			obj.duo.op.OpI<P, P1, R> op
			,
			_var.VarI_dynamicTyped arg
			,
			_form.FormI_dynamic arg1
		)
			: base(op,
				  new _expr.Var(arg)
				  , 
				  new _expr.Form(arg1)
				  )
		{
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg.type, typeof(P));
			nilnul.obj.type.rel.IsSubTypeOfX.Assert(arg1.type, typeof(P1));

		}

		public Call(
			obj.duo.op.OpI<P, P1, R> op
			,
			_var.VarI_dynamicTyped arg
			,
			_expr.ExprI_dynamic arg1
		)
			: this(op,
				  new _expr.Var(arg)
				  , 
				  arg1
				  )
		{
			

		}


		public _expr.ExprI_dynamic reduce()
		{
			var argDemoted = arg.reduce();
			var arg1Demoted = arg1.reduce();

			if (argDemoted is _expr.FormI && arg1Demoted is _expr.FormI)
			{

				var xx = (argDemoted as _expr.FormI);
				var yy = (arg1Demoted as _expr.FormI);
				return new _expr.Form<R>(

					new nilnul.obj.form.duo.Call_argDynamic<P, P1, R>(

						op,

						xx.form
						,
						yy.form
					).eval_staticTyped()

				);

			}
			return new Call<P,P1,R>(

					op,

					argDemoted
					,
					arg1Demoted
			);

			throw new NotImplementedException();
		}



		public ExprI_dynamic substitute(VarI_dynamicTyped var, ExprI_dynamic expr)
		{
			return new Call<P, P1, R>(op, arg.substitute(var, expr), arg1.substitute(var, expr));


			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return $"{this.op.ToString()}({arg.ToString()},{arg1.ToString()})";// base.ToString();
        }
	}
}
