using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{

	
	[Obsolete()]

	public interface StartedI<T> : StartedI , _started_.HeadI<T>{



	}


	[Obsolete()]

	public interface StartedI<T, TTail> 
		: 
		StartedI<T>
		, 
		_started_.TailI<TTail>

		where TTail: nilnul.ObjsI<T>
	{
	}

	[Obsolete()]
	public class StartedA<T, TTail>
		: _started_.HeadA<T>
		,_started_.TailI<TTail>
	{

		

		public StartedA(T head, TTail tail) : base(head)
		{
			_tail = tail;

		}

		private TTail _tail;

		public TTail tail
		{
			get
			{
				return _tail;
				throw new NotImplementedException();
			}
			set {
				_tail = value;
			}
		}
	}
	[Obsolete()]
	public class Started<T, TTail>
		: StartedA<T, TTail>

		where TTail : nilnul.ObjsI<T>

	{
		public Started(T head, TTail tail) : base(head, tail)
		{
		}
	}

	[Obsolete()]
	public class Started1<T, TTail>
		: StartedA<T, TTail>
		,nilnul.ObjsI1<T>

		where TTail : nilnul.ObjsI1<T>

	{
		public Started1(T head, TTail tail) : base(head, tail)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return head;
			foreach (var item in tail)
			{
				yield return item;
			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}



}
