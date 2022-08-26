using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs
{
	public class StartedD<T,TStr>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private TStr _tail;

		public TStr tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public StartedD(T head, TStr tail)
		{
			_head = head;
			_tail = tail;
		}

	}

	public class Started<T, TStr>
		: StartedD<T, TStr>, IEnumerable<T>
		where TStr : IEnumerable<T>
	{
		public Started(T head, TStr tail) : base(head, tail)
		{
		}

		public IEnumerator<T> GetEnumerator()
		{
			yield return this.head;
			foreach (var item in tail)
			{
				yield return item;
			}
			//throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();

			//throw new NotImplementedException();
		}
	}

	public class Started<T>
		: Started<T, IEnumerable<T>>

	{
		public Started(T head, IEnumerable<T> tail) : base(head, tail)
		{
		}
	}


}
