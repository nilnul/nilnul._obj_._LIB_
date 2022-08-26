using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider
{
	public class Dehead<T>
		: nilnul.obj.Box<SliderI<T>>
		,
		SliderI<T>
	{

		public Dehead(SliderI<T> val) : base(val)
		{
			this.boxed.moveNext();
		}

		public T current => this.boxed.current;

		public void moveNext()
		{
			boxed.moveNext();
			//throw new NotImplementedException();
		}

		public T next()
		{
			return obj.stream_._slider_.NextX.Next(this);
		}
	}
}
