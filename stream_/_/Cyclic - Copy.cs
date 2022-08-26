using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.str.to;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj.str_.started_;

namespace nilnul.obj.stream_
{

	public class Cyclic_ofSeq<T> :
		nilnul.obj.Box<IEnumerable<T>>
		,
		nilnul.obj.StreamI2<T>
	{

		public IEnumerable<T> started
		{
			get { return boxed; }
			set { boxed = value; }
		}


		private IEnumerator<T> _enumerator;

		public IEnumerator<T> enumerator
		{
			get { return _enumerator; }
			set { _enumerator = value; }
		}


		public Cyclic_ofSeq(OfArr<T> val) : base(val)
		{
			_enumerator = boxed.GetEnumerator();
		}

		public Cyclic_ofSeq(T[] arr):this( new OfArr<T>(arr))
		{

		}

		public Cyclic_ofSeq(IEnumerable<T> seq):base(seq)
		{

		}

		public T next()
		{


			if (!_enumerator.MoveNext())
			{
				_enumerator.Reset();
				_enumerator.MoveNext();

			}
			return _enumerator.Current;



		}
	}
}
