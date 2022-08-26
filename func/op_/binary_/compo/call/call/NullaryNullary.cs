using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func.op.compo.call
{
	public partial class NullaryNullary<TInExpr, TInExpr1>
	{
		private obj.func.Nullary<TInExpr> _nullary;

		public obj.func.Nullary<TInExpr> nullary
		{
			get { return _nullary; }
			set { _nullary = value; }
		}
		private obj.func.Nullary<TInExpr1> _func1;

		public obj.func.Nullary<TInExpr1> func1
		{
			get { return _func1; }
			set { _func1 = value; }
		}

		public obj.func.Nullary<TInExpr1> eval() {
			return _func1;
		}

	}
}
