using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.collection.set.rel
{
	public partial class Empty<T>:nilnul_obj.bit.Predicate<IEnumerable<T>>
	{

		public Empty()
			:base(EmptyX.Is)
		{

		}
					
	}

	
}
