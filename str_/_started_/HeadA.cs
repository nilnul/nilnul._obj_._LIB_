using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_._started_
{
	public class HeadA<T>:HeadI<T>
	{

		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		public HeadA(T head)
		{
			_head = head;
		}

	}
}
