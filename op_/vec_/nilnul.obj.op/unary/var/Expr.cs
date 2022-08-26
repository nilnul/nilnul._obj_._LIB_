using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary.var
{
	public partial class Expr<P,R>
		
	{
		private op.unary.VarI<P,R>	_op;

		public op.unary.VarI<P,R> op
		{
			get { return _op; }
			set { _op= value; }
		}

		private obj.VarI<P> _arg;

		public obj.VarI<P> arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Expr(VarI<P,R> op, obj.VarI<P> arg)
		{
			this._op = op;
			this._arg = arg;

		}
		public Expr(
			op.Unary<P,R> op
			,
			P arg
		)
			:this(new op.unary.var.Literal<P,R>(op),new obj.var.Literal<P>(arg))
		{

		}

		public  string ToStr(obj.var.NamingContext naming)
		{


			return base.ToString();
		}
		
		
	}
}
