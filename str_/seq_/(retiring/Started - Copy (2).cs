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
	public class Started<T> :
		nilnul.obj.seq_.GetEnumeratorA<T>
		,
		nilnul.obj.str_.SeqI1<T>
		//,
		//SeqI2<T>
	{
		private T _head;

		public T head
		{
			get { return _head; }
			set { _head = value; }
		}

		private str_.SeqI1<T> _tail;

		public str_.SeqI1<T> tail
		{
			get { return _tail; }
			set { _tail = value; }
		}

		public Ee_beDyna<T> seq => new Ee_beDyna<T>(
			new[] {_head}.Concat(_tail.seq.ee)
			,
			_tail.seq.be
		);

		public Started(T head, IEnumerable<T> boxed) 
		{
			_head = head;
			_tail = new nilnul.obj.str_.Seq<T>(boxed);
		}

		public override IEnumerator<T> GetEnumerator()
		{
			yield return _head;
			foreach (var item in _tail.seq.ee)
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
