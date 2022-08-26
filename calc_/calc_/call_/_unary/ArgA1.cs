using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_._unary
{
	public abstract class ArgA< TArg> :  ArgI<TArg>
		
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public ArgA(TArg arg) 
		{
			_arg = arg;
		}
	}
}
