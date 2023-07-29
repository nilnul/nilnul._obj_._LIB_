using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_
{

	public abstract class SliderA<T> :

		SliderI<T>
	{
		public abstract T current { get; }

		public abstract void moveNext();
		public T next() {
			var old = current;
			moveNext();
			return old;

		}
	}
}
