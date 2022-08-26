using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._expr;
using nilnul.obj.call._call;
using nilnul.obj.expr.stati.no._call;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr.stati.no
{
	public class Call<T>:Call<obj.no.OpI<T>,T>
	{

		public Call(obj.no.OpI<T> op):base(op)
		{

		}
		public Call(T val) : this(new obj.no.Op<T>(val))
		{

		}

	}


	public class Call<TOp, TR>
		: nilnul.obj.CallA<TOp>
		,
		expr.StatiI<TR>
		,_call.EvalI<TR>
		,obj.call._call.OpI

		where TOp :obj.no.OpI<TR>


	{

		public Call(TOp op):base(op)
		{

		}


		public obj.var.stati.Set vars
		{
			get
			{
				return new obj.var.stati.Set();
				throw new NotImplementedException();
			}
		}

		OpI call._call.OpI.op
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

		public StatiI<TR> reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		
		public StatiI<TR> substitute<V>(obj.var.Stati<V> var, StatiI<V> expr)
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
