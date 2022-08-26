using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	

	public class Co<T> : Tuple<T, T>
		,CoI2<T>
	{
		public T component => base.Item1;

		public T component1 => base.Item2;

		public Co(T item1, T item2) : base(item1, item2)
		{

		}

		public Co(Tuple<T,T> tuple):this(tuple.Item1,tuple.Item2)
		{

		}

		public Co((T,T) valTuple):this(valTuple.Item1,valTuple.Item2)
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
