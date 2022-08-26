using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete()]
	public class Duo<T> : Tuple<T, T>
	{
		public Duo(T item1, T item2) : base(item1, item2)
		{

		}

		public Duo(Tuple<T,T> tuple):this(tuple.Item1,tuple.Item2)
		{

		}

		//static public implicit operator Duo<T>(Tuple<T,T> tuple) {
		//	return new Duo<T>(
		//		tuple
		//	);
		//}
		//user to and from base class not allowed
	}
}
