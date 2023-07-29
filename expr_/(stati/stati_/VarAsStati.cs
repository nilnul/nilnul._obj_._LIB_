using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.var.stati;

namespace nilnul.obj.expr.stati
{
	public interface VarAsStatiI {

	}

	public class VarAsStati<T>
		:obj.expr.StatiI<T>,VarAsStatiI
	{
		private obj.var.Stati<T> _var;

		public obj.var.Stati<T> var
		{
			get { return _var; }
			set { _var = value; }
		}

		public obj.var.stati.Set vars
		{
			get
			{
				return new obj.var.stati.Set() {this._var };
				throw new NotImplementedException();
			}
		}

		

		public VarAsStati(obj.var.Stati<T> var)
		{
			_var = var;
		}

		public StatiI<T> reduce()
		{

			return this;
			throw new NotImplementedException();
		}

		public StatiI<T> substitute<V>(obj.var.Stati<V> var, StatiI<V> expr)
		{
			if ((obj.var.StatiI)var==(obj.var.StatiI)_var)
			{

				return expr as StatiI<T>;
			}
			else
			{
				return this;
			}
			throw new NotImplementedException();
		}
		public override string ToString()
		{
			return _var.ToString();
		}
	}
}
