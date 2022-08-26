using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.seq.be_.finite.vow;

namespace nilnul.obj.str_.seq_
{
	[Obsolete()]
	public class Started2<T> :
		nilnul.obj.seq_.GetEnumeratorA<T>
		
		,
		SeqI2<T>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private str_.SeqI2<T> _tail;

		public str_.SeqI2<T> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Started2(T head, SeqI2<T> tail) 
		{
			_head = head;
			_tail = tail;
		}
		

		public Started2(T head, IEnumerable<T> tail) :this(head, new Seq2<T>(tail))
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

		public Sans0StartedI<T> toSans0Started()
		{
			return new str_.sans0Started_.Started<T>(this.head, this.tail.toSans0Started());
		}

		//public override T[] toArr()
		//{
		//	return this.ToArray();
		//	throw new NotImplementedException();
		//}
	}
}
