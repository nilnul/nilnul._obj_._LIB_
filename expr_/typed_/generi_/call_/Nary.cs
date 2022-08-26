using nilnul.obj._expr.expr0lamda.be_.nonlamda.vow;
using nilnul.obj.expr.be_.typed_.generi.vow;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.typed_.generi_.call_
{
	public class Nary<TLiteral, TOp> :
		nilnul.obj._call_.OpA2<TOp>
		,
		nilnul.obj.expr_.typed_.generi_.CallI<TLiteral>
		,
		generi_.IClosed<TLiteral>
		,
		generi_.ClosedI<TLiteral>
		where TOp : nilnul.obj.op_.NaryI<TLiteral>
	{
		public Nary(TOp op) : base(op)
		{
		}
		public TLiteral constant { get {
				return op.op();
		} }

		public override string ToString()
		{
			return op.op().ToString();
		}
		public ConstantExpression expression { get {
				return Expression.Constant(constant);
		} }
		public Ee expr =>  new Ee(expression) ;


		public Ee<TLiteral> generi => new Ee<TLiteral>(
			new Expr4(
			expr
			)
		);

		public generi.be_.closed.vow.Ee<TLiteral> closed => new typed_.generi.be_.closed.vow.Ee<TLiteral>(
			new Generi<TLiteral>(
			this.generi.ee
			)
		);
	}

	public class Nary<TLiteral> :
		Nary<TLiteral, nilnul.obj.op_.NaryI<TLiteral>>
		
	{
		public Nary(TLiteral val) : base( new nilnul.obj.op_.Nary<TLiteral>(val))
		{
		}

		public Nary(nilnul.obj.op_.NaryI<TLiteral> op):base(op)
		{

		}
		public override string ToString()
		{
			return op.op().ToString();
		}

	}

	

}
