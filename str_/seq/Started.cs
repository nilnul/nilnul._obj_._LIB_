using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace nilnul.obj.str_.seq
{
	public class Started<T> :
		nilnul.obj.str_.SeqA1<T>
		,
		nilnul.obj.str_.SeqI<T>
	{
		private T _head;
		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private nilnul.obj.str_.SeqI<T> _tail;

		public nilnul.obj.str_.SeqI<T> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}


		public Started(T head, nilnul.obj.str_.SeqI<T> tail) 
		{
			_head = head;
			_tail = tail;
		}

		public Started(T head, IEnumerable<T> boxed) :this(
			head
			, 
			new nilnul.obj.str_.Seq<T>(boxed) 
		)
		{
		}

		public Started(IEnumerable<T> boxed) :this(
			boxed.First()
			, 
			boxed.Skip(1)
		)
		{
		}
		public Started(params T[] boxed) :this(
			(IEnumerable<T>)boxed
		)
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

		//public override T[] toArr()
		//{
		//	return this.ToArray();
		//	throw new NotImplementedException();
		//}
	}
}
