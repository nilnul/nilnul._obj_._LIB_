using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func_
{
	public interface OutputI<out TRule>
		where TRule : nilnul.obj._expr_.BlankI
	{
		TRule output { get; }
	}


	public class Output<TRule> 
		:
		OutputI<TRule>
		where TRule : nilnul.obj._expr_.BlankI

	{
		private TRule _output;
		public TRule output
		{
			get
			{
				return _output;
				//throw new NotImplementedException();
			}
		}

		public Output(TRule output)
		{
			_output = output;
		}
	}

	
}
