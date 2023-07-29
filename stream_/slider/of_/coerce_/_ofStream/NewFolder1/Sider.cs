using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using nilnul.obj._stream_;

namespace nilnul.obj.stream_
{
	[Obsolete(nameof(stream_.slider.of_.coerce_._OfStreamX))]
	public class Sider<T>
		:
		nilnul.obj.Box_ofIn<
			nilnul.obj.StreamI2<T>
		>
		,
		nilnul.obj.stream_.SliderI<T>
	{
		public Sider(nilnul.obj.StreamI2<T> val) : base(val)
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

		public T next()
		{
			return _slider_.NextX.Next(this);

		}
	}
}
