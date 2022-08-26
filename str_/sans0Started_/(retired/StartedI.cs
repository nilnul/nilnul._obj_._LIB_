using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_
{
	[Obsolete()]
	public interface StartedI :StrI{

	}
	[Obsolete()]
	public interface StartedI<T>: _started_.HeadI<T>, _started_.TailI<obj.StrI<T>>, obj.StrI<T>
	{

	}

	[Obsolete()]
	public interface StartedI<THead, TTail> :

		_started_.HeadI<THead>
		,
		_started_.TailI<TTail>

		where TTail:nilnul.obj.StrI<THead>

	{

	}

	[Obsolete()]
	public class Started<T, TStr> 
		:StartedI<T,TStr>, nilnul.obj.StrI<T>
		where TStr:nilnul.obj.StrI<T>
	{

		public Started(T head, TStr tail )
		{
			_head = head;
			_tail = tail;

		}
		private T _head;
		public T head
		{
			get
			{
				return _head;
				//throw new NotImplementedException();
			}
		}

		private TStr _tail;

		public TStr tail
		{
			get
			{
				return _tail;
				//throw new NotImplementedException();
			}
		}
	}
}
