using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.obj._var;

namespace nilnul.obj.var._str
{
	public class Enumerable_ofVarWithType
		:
		StrI
		//,

		//IEnumerable<_var.VarWithTypeI>

	{
		private IEnumerable<_var.VarI_dynamicTyped> _vars;

		public IEnumerable<_var.VarI_dynamicTyped> vars
		{
			get { return _vars; }
			set { _vars = value; }
		}

		public Enumerable_ofVarWithType()
		{
			_vars = new _var.VarI_dynamicTyped[0];

		}

		public IEnumerator<VarI_dynamicTyped> GetEnumerator()
		{
			return _vars.GetEnumerator();

			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}

		static public Enumerable_ofVarWithType CreateEmpty() {
			return new Enumerable_ofVarWithType();
		}
	}
}
