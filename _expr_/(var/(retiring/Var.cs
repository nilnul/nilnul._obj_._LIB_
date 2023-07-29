using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._var;
using nilnul.obj.var.set;
using nilnul.obj._expr._members;

namespace nilnul.obj._expr
{
	public class Var :ExprI_dynamic
	{
		private VarI_dynamicTyped _var;

		public nilnul.obj._var.VarI_dynamicTyped var
		{
			get { return _var; }
			set { _var = value; }
		}

		public Type type
		{
			get
			{
				return _var.type;
				throw new NotImplementedException();
			}
		}

	

		public HashSet<VarI_dynamicTyped> vars
		{
			get
			{
				return new HashSet<VarI_dynamicTyped>() {_var };
				throw new NotImplementedException();
			}
		}

		public Var(nilnul.obj._var.VarI_dynamicTyped var)
		{
			_var = var;
		}

		public ExprI_dynamic reduce()
		{
			return this;
			throw new NotImplementedException();
		}

		public ExprI_dynamic substitute(VarI_dynamicTyped var, ExprI_dynamic expr)
		{

			if (var==this._var)
			{
				if (nilnul.obj.type.rel.IsSubTypeOfX.Eval(expr.type,var.type) )
				{

					return expr;

				}
				throw new _exceptions.TypeNotMatchException();

				
			}
			else
			{
				return this;
			}

			throw new NotImplementedException();
		}

		public override string ToString()
		{
			return  $"{_var.type} {nilnul.obj.var.NamingContextX.ToTxt( _var)}";
		}

	}
}
