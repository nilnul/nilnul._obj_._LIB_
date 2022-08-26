using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_
{
	[Obsolete()]
	public class Slider<T> : nilnul.obj.Box<nilnul.obj.SliderI<T>>, nilnul.obj.StreamI<T>
	{
		public Slider(SliderI<T> val) : base(val)
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
