using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream
{
	/// <summary>
	/// a cyclic buffer of a fixed size;
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TStream"></typeparam>
	public class Buffered<T, TStream>
		:
		nilnul.obj.Box<TStream>
		,
		BufferedI<T>
		,
		nilnul.obj.StreamI2<T>
		where TStream : nilnul.obj.StreamI2<T>
	{
		private nilnul.obj.Buffer<T> _buffer;
		public nilnul.obj.Buffer<T> buffer => _buffer;

		public Buffered(TStream val, int count) : base(val)
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
	}

	public class Buffered<T> :
		Buffered<T, nilnul.obj.StreamI2<T>>
	{

		public Buffered(nilnul.obj.StreamI2<T> val, int count) : base(val, count)
		{

		}


	}


}
