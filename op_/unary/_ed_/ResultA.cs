using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.op_.unary._ed_
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

		public override string ToString()
		{
			return _result.ToString();
		}
	}
}
