using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{

	public class Buffered<T, TSlider> :
		nilnul.obj.Box<TSlider>
		,
		BufferedI<T>
		,
		nilnul.obj.stream_.SliderI<T>
		,
		slider_.IPreview
		where TSlider : nilnul.obj.stream_.SliderI<T>
	{
		private nilnul.obj.Buffer<T> _buffer;
		public nilnul.obj.Buffer<T> buffer => _buffer;

		public T current => _buffer.boxed[0];

		public Buffered(TSlider val, int count) : base(val)
		{
			if (count < 1)
			{
				throw new Exception($"{count} must be positive.");
			}
			_buffer = new Buffer<T>(val.Fetch(count));
		}

		public void move()
		{
			_buffer.pump(boxed.next());
		}

		public T next()
		{
			var old = _buffer.boxed[0];
			move();
			return old;
			//throw new NotImplementedException();
		}

		public void moveNext()
		{
			move();
		}
	}


	public class Buffered<T> :
		Buffered<T, nilnul.obj.stream_.SliderI<T>>
	{

		public Buffered(nilnul.obj.stream_.SliderI<T> val, int count) : base(val, count)
		{

		}

	}


}
