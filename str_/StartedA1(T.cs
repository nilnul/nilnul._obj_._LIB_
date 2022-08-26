using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{

	

	

	public class StartedA1<T, TTail>
		: _started_.HeadA<T>
		,_started_.TailI<TTail>
	{
	

		public StartedA1(T head, TTail tail) : base(head)
		{
			_tail = tail;

		}

		private TTail _tail;

		public TTail tail
		{
			get
			{
				return _tail;
				//throw new NotImplementedException();
			}
			set {
				_tail = value;
			}
		}
	}



}
