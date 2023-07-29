using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;

namespace nilnul.obj.slider
{
	[Obsolete()]
	public class FroStream<T>
		: nilnul.obj.Box<nilnul.obj._stream_.NextI<T>>
		,nilnul.obj.SliderI<T>
	{
		public FroStream(nilnul.obj._stream_.NextI<T> val) : base(val)
		{
			moveNext();

		}

		private T _current;

		public T current
		{
			get
			{
				return _current;
				//throw new NotImplementedException();
			}
		}

		public void moveNext()
		{
			_current = this.boxed.next();
			//throw new NotImplementedException();
		}
	}
}
