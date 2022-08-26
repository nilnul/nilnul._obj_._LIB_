using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._func_
{
	public interface BodyI<out TRule>
		where TRule : nilnul.obj._expr_.BlankI
	{
		TRule body { get; }
	}


	public class Body<TRule> 
		:
		BodyI<TRule>
		where TRule : nilnul.obj._expr_.BlankI

	{
		private TRule _body;
		public TRule body
		{
			get
			{
				return _body;
				//throw new NotImplementedException();
			}
		}

		public Body(TRule body)
		{
			_body = body;
		}
	}

	
}
