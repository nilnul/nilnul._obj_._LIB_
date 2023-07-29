using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_._binary
{
	[Obsolete(nameof(obj.calc_._binary.Arg1<T>))]
	public interface Arg1I<out T>
	{
		T arg1 { get; }
	}

	[Obsolete(nameof(obj.calc_._binary.Arg1<TArg>))]
	public class Arg1<TArg> : Arg1I<TArg>

	{
		private TArg _arg1;

		public TArg arg1
		{
			get { return _arg1; }
			set { _arg1 = value; }
		}

		public Arg1(TArg arg1)
		{
			_arg1 = arg1;
		}
	}

}
