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

	public class  Binary<TLiteral, TArg, TOp> :
		nilnul.obj._call_.OpArgArg1A<TOp, TArg>
		,
		nilnul.obj.expr_.typed_.generi_.CallI<TLiteral>

		where TOp : nilnul.obj.op_.BinaryI<TLiteral>
		where TArg : nilnul.obj.expr_.typed_.GeneriI<TLiteral>
	{
		public Binary(TOp op, TArg arg,TArg arg1) : base(op, arg,arg1)
		{
		}

		/// <summary>
		/// consider using <see cref="methodCallExpression"/>
		/// </summary>
		public BinaryExpression binaryExpression
		{
			get
			{
				return System.Linq.Expressions.Expression.MakeBinary(
					System.Linq.Expressions.ExpressionType.Call,
					this.arg.generi.ee.expr.ee
					,
					this.arg1.generi.ee.expr.ee
					,false,

					//typeof(TLiteral),
					op.GetType().GetMethod(
						nameof(op.op), new[] { typeof(TLiteral),typeof(TLiteral) }
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
						nameof(op.op), new[] { typeof(TLiteral),typeof(TLiteral) }
					)
					,

					
					this.arg.generi.ee.expr.ee
					,
					this.arg1.generi.ee.expr.ee
					
				);



			}
		}

		public Ee expr => new Ee(binaryExpression);


		public Ee<TLiteral> generi => new Ee<TLiteral>(
			new Expr4(
			expr
			)
		);


	}

	public class Binary<TLiteral> :
	Binary<TLiteral, nilnul.obj.expr_.typed_.GeneriI<TLiteral>, nilnul.obj.op_.BinaryI<TLiteral>>



	{
		public Binary(BinaryI<TLiteral> op, GeneriI<TLiteral> arg, GeneriI<TLiteral> arg1) : base(op, arg,arg1)
		{
		}
	}
}
