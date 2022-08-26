using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.calc_._unary
{
	public interface ArgI<out T>
	{
		T arg { get; }
	}
	public  class Arg< TArg> :  ArgI<TArg>
		
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Arg(TArg arg) 
		{
			_arg = arg;
		}
	}
}
