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

namespace nilnul.obj.stream.of_.str_.seq_.started_
{

	public class Cyclic<T> :
		nilnul.obj.Box1<nilnul.obj.str_.seq_.Started3<T>>
		,
		nilnul.obj.StreamI2<T>
	{

		public nilnul.obj.str_.seq_.Started3<T> started
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


		public Cyclic(nilnul.obj.str_.seq_.Started3<T> val) : base(val)
		{
			_enumerator = boxed.GetEnumerator();
		}

		public Cyclic(T[] arr):this( new nilnul.obj.str_.seq_.Started3<T>(arr))
		{

		}

		public Cyclic(IEnumerable<T> arr):this( new nilnul.obj.str_.seq_.Started3<T>(arr))
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
