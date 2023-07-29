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

namespace nilnul.expr.no._call
{
	[Obsolete()]
	public class Call< TR>:EvalI<TR>
	{
		private TR _result;

		public TR result
		{
			get { return _result; }
			set { _result = value; }
		}

		public Call(TR result)
		{
			_result = result;
		}

		public override string ToString()
		{
			return this._result.ToString();
		}

		public TR eval()
		{
			return _result;
			throw new NotImplementedException();
		}
	}
}
