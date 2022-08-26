using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj._converted_
{
	public abstract class ResultA<T>
		: ResultI<T>
	{
		public ResultA(T processed)
		{
			_result = processed;
		}
		private T _result;
		public   T result
		{
			get { return _result; }
		}
	}
}
