using nilnul.obj._expr.untyped.be_.ofType_.typed.vow;
using nilnul.obj._func;
using nilnul.obj._func.untyped.be_.ofType_.typed.vow;
using nilnul.obj.op_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_
{

	/// <summary>
	/// 
	/// </summary>

	public class Nary :
		nilnul.obj.calc_.Nary< obj.FuncI3>
		,
		func.calc_.LamdaI
	{
		public Nary(NaryI<FuncI3> op) : base(op)
		{
		}

		public Nary(FuncI3 r) : base(r)
		{
		}

		public Nary(Func3 r) : base(r)
		{
		}

		public Nary( LambdaExpression lambda):this(
			new Func3(lambda)
		)
		{
		}

		/// <summary>
		/// Note: in fact we can use unary/binary/any-ary func here. To avoid misleading confusion, don't use this.
		/// </summary>
		/// <param name="lambda"></param>
		public Nary( nilnul.obj.ExprI4 lambda):this(
			new func_.Ni(lambda)
		)
		{
		}


		public LambdaExpression lambda =>this.op.op().flat.ee;


	}
}
