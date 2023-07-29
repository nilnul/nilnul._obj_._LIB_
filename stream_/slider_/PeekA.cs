using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.stream_.slider_
{

	public abstract class PeekA<T>
		:
		SliderA<T>
		,
		PeekI<T>
	{
		

		public abstract T ahead { get; }

		
	}
}
