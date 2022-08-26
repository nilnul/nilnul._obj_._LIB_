using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func._invoke_
{


	public abstract class InputA<TRule> 
		:
		InputI<TRule>
		where TRule : nilnul.obj._expr_.BlankI

	{
		private TRule _input;
		public TRule input
		{
			get
			{
				return _input;
				//throw new NotImplementedException();
			}
		}


		public InputA(TRule body)
		{
			_input = body;
		}
	}

	
}
