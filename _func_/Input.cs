using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func_
{
	public interface InputI<out T>
		where T: nilnul.obj._func._input_.BlankI
	{
		T input { get; }
	}

	public class Input<TInput>
	:
	InputI<TInput>
		where TInput: nilnul.obj._func._input_.BlankI
	{
		private TInput _input;
		public TInput input
		{
			get
			{
				return _input;
				//throw new NotImplementedException();
			}
		}

		public Input(TInput input)
		{
			_input = input;
		}
	}

}
