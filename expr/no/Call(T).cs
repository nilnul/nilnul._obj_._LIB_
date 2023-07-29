using nilnul.obj._expr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._var;


namespace nilnul.obj.expr.no
{
	[Obsolete()]
	public class Call<T>

		:ExprI_blank
		,_expr.ExprI_dynamic

	{

		private obj.no.Op<T> _op;

		public obj.no.Op<T> op
		{
			get { return _op; }
			set { _op = value; }
		}

		public Type type
		{
			get
			{
				return typeof(T);
				throw new NotImplementedException();
			}
		}

		public HashSet<VarI_dynamicTyped> vars
		{
			get
			{
				return new obj.var.Set();
				throw new NotImplementedException();
			}
		}

		public ExprI_dynamic reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI_dynamic substitute(VarI_dynamicTyped var, ExprI_dynamic expr)
		{
			return this;
			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return _op.ToString();
		}
	}
}
