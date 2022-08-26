using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.no._call_
{

	public abstract class EvalA<T>
	{

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		public EvalA(T val)
		{

		}

		public T eval() {
			return _val;
		}

		public override string ToString()
		{
			return _val.ToString();
		}
	}
}
