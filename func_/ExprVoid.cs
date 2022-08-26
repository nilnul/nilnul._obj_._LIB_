using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{
	[Obsolete()]
	public partial class ExprVoid
		:nilnul.obj.expr.ExprI<Void>
	{
		static public ExprVoid Singleton = SingletonByDefault<ExprVoid>.Instance;

		public expr.ExprI<Void> substitute<V>(VarI3<V> var, expr.ExprI<V> expr)
		{
			return this;
			throw new NotImplementedException();
		}

		public expr.ExprI<Void> demote()
		{
			return this;
			throw new NotImplementedException();
		}
	}
}
