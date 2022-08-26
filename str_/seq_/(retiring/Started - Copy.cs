using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.enumable_
{
	[Obsolete(nameof(seq_.started))]
	public class Started<T> :  nilnul.obj.str_.EnumableA<T>
		,
		nilnul.obj.str_.SeqI<T>
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


		public Started(T head, IEnumerable<T> boxed) 
		{
			_head = head;
			_tail = boxed;
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

		//public override T[] toArr()
		//{
		//	return this.ToArray();
		//	throw new NotImplementedException();
		//}
	}
}
