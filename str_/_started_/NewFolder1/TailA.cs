using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_._started_
{
	public class TailA<T>:TailI<T>
	{

		private T _tail;

		public T tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public TailA(T tail)
		{
			_tail = tail;
		}

	}
}
