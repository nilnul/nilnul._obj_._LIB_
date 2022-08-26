using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_.call_
{
	public class Unary<TLiteral, TArg, TOp> :
		nilnul.obj._call_.OpArgA<TOp, TArg>
		,
		nilnul.obj.expr_.typed_.generi_.CallI<TLiteral>

		where TOp : nilnul.obj.op_.UnaryI<TLiteral>
		where TArg : nilnul.obj.expr_.typed_.GeneriI<TLiteral>
	{
		public Unary(TOp op, TArg arg) : base(op, arg)
		{
		}

		/// <summary>
		/// consider using <see cref="methodCallExpression"/>
		/// </summary>
		//[Obsolete()]
		public UnaryExpression unaryExpression
		{
			get
			{
				return System.Linq.Expressions.Expression.MakeUnary(
					System.Linq.Expressions.ExpressionType.Call,
					this.arg.generi.ee.expr.ee,
					typeof(TLiteral),
					op.GetType().GetMethod(
						nameof(op.op), new[] { typeof(TLiteral) }
					)
				);
			}
		}

		public MethodCallExpression methodCallExpression
		{
			get
			{
				return System.Linq.Expressions.Expression.Call(
					Expression.Constant(
						this.op
					)
					,
					op.GetType().GetMethod(
						nameof(op.op), new[] { typeof(TLiteral) }
					)
					,
					this.arg.generi.ee.expr.ee
				);
			}
		}

		public Ee expr => new Ee(unaryExpression);


		public Ee<TLiteral> generi => new Ee<TLiteral>(
			new Expr4(
			expr
			)
		);


	}

	public class Unary<TLiteral> :
	Unary<TLiteral, nilnul.obj.expr_.typed_.GeneriI<TLiteral>, nilnul.obj.op_.UnaryI<TLiteral>>



	{
		public Unary(UnaryI<TLiteral> op, GeneriI<TLiteral> arg) : base(op, arg)
		{
		}
	}
}
