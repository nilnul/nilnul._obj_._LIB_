using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.unary.var
{
	public abstract partial class ExprA<TOp,TArg>
		where TOp:nilnul.obj.VarI
		where TArg:nilnul.obj.VarI
	{
		private TOp	_op;

		public TOp op
		{
			get { return _op; }
			set { _op= value; }
		}

		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public ExprA(TOp op, TArg arg)
		{
			this._op = op;
			this._arg = arg;

		}

		public string toStr(nilnul.obj.var.NamingContext naming) {

			return string.Format("{0}({1})",naming.get(_op),naming.get(_arg));
		
		}

		public override string ToString()
		{
			return base.ToString();
		}
	


		
		
	}
}
