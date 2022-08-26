using nilnul.obj.seq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_
{
	public class Started<T>:
		_seq_.GetEnumeratorA<T>,

		IEnumerable<T>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}
		private IEnumerable<T> _tail;

		public IEnumerable<T> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}
		public Started(T head0, IEnumerable<T> tail0)
		{
			_head = head0;
			_tail = tail0;
		}

		public Started(IEnumerable<T> seq):this(seq.First(), seq.Skip())
		{
			
		}

		public override IEnumerator<T> GetEnumerator()
		{
			yield return _head;
			foreach (var item in _tail)
			{
				yield return item;
			}
			//throw new NotImplementedException();
		}

		
	}
}
