using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul._call;
using nilnul._expr;
using nilnul._op;
using nilnul.obj._expr;
using nilnul.obj.call._call;
using nilnul.obj.expr.stati.no._call;
using nilnul.obj.var.stati;
using nilnul.var;

namespace nilnul.expr.no
{
	[Obsolete()]
	public class Call<T>:Call<nilnul.no.OpI<T>,T>
	{

		public Call(nilnul.no.OpI<T> op):base(op)
		{

		}
		public Call(T val) : this(new nilnul.no.Op<T>(val))
		{

		}

	}


	public class Call<TOp, TR>
		: nilnul._call.Call_OpA<TOp>
		,
		nilnul.ExprI_membered<TR>

		,_call.EvalI<TR>
		

		where TOp :nilnul.no.OpI<TR>


	{

		public Call(TOp op):base(op)
		{

		}


		public Set_ofVarI vars
		{
			get
			{
				return new var.Set_ofVarI();
				throw new NotImplementedException();
			}
		}

		_op.OpI_generic nilnul._call.OpI<_op.OpI_generic>.op
		{
			get
			{
				return this.op;
				throw new NotImplementedException();
			}
		}

		public TR eval()
		{
			return op.eval();
			throw new NotImplementedException();
		}

		public ExprI_membered<TR> reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI_membered<TR> substitute<V>(VarI1<V> var, ExprI_membered<V> expr)
		{
			return this;


			throw new NotImplementedException();
		}

		

		public override string ToString()
		{
			return this.op.eval().ToString();
		}

	
	}
}
