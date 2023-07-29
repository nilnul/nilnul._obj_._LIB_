using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.calc_._ternary
{
	public interface Arg2I<out T>
	{
		T arg2 { get; }
	}

	public class Arg2<TArg> : Arg2I<TArg>

	{
		private TArg _arg2;

		public TArg arg2
		{
			get { return _arg2; }
			set { _arg2 = value; }
		}

		public Arg2(TArg arg2)
		{
			_arg2 = arg2;
		}
	}

}
