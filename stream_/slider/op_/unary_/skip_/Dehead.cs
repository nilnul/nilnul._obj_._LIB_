using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.slider_.skip_
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
	}
}
