using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.expr;
using nilnul.obj.func.dfn;
using nilnul.obj.var;
using nilnul.obj.var.withType.s;

namespace nilnul.obj.func.varWithType
{
	public partial class Func_varsWithType_exprT<TInExpr>
		: FuncI_varsWithType_exprT<TInExpr>
	{
		private expr.ExprI<TInExpr> _expr;
        public expr.ExprI<TInExpr> expr
		{
			get
			{
				return _expr;
				throw new NotImplementedException();
			}
			set {
				_expr = value;
			}
		}
		private var.withType.s.SortedSet _vars;
		public SortedSet vars
		{
			get
			{
				return _vars;
				throw new NotImplementedException();
			}
			set {
				_vars = value;
			}
		}
	}
}
