using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	[Obsolete(nameof( obj.set_.EqDefaulted<T,TEq>))]
	public class Set<T,TEq> : Set1<T>
		where TEq:IEqualityComparer<T>, new()
	{

		public Set():base(SingletonByDefault<TEq>.Instance  )
		{
			
		}



		public Set(params T[] vars):base(vars, SingletonByDefault<TEq>.Instance)
		{
		}

		public Set(IEnumerable<T> elements):base(elements, SingletonByDefault<TEq>.Instance)
		{

		}
	}
}
