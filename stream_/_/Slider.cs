using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.slider
{
	public class Stream<T> : nilnul.obj.Box<nilnul.obj.SliderI<T>>
		, 
		nilnul.obj._stream_.NextI<T>
	{
		public Stream(SliderI<T> val) : base(val)
		{
		}

		public T next()
		{
			var old = boxed.current;
			boxed.moveNext();
			return old;
			//throw new NotImplementedException();
		}

		
	}
}
