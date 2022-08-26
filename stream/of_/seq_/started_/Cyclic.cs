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

namespace nilnul.obj.stream.of_.seq_.started_
{

	public class Cyclic<T> :
		nilnul.obj.Box1<nilnul.obj.seq_.Started<T>>
		,
		nilnul.obj.StreamI2<T>
	{

		public nilnul.obj.seq_.Started<T> started
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


		public Cyclic(nilnul.obj.seq_.Started<T> val) : base(val)
		{
			_enumerator = boxed.GetEnumerator();
		}

		public Cyclic(T[] arr):this( new nilnul.obj.seq_.Started<T>(arr))
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
