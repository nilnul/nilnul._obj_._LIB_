using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.seq.be_.finite.vow;

namespace nilnul.obj.str_.seq_
{
	[Serializable]
	public class Started3<T> :
		nilnul.obj._seq_.GetEnumeratorA<T>
		
		,
		IEnumerable<T>
		,
		str_.SeqI3<T>
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

		public Started3(T head, IEnumerable<T> tail) 
		{
			_head = head;
			_tail = tail;
		}
		

		public Started3( IEnumerable<T> tail) :this(tail.First(), tail.Skip(1) )
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
