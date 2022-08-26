using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq_.enumerable.be_
{
	public class Finite<T> : BeI<T>
	{
		public bool be(IEnumerable<T> obj)
		{
			 obj.LongCount();
			return true;
		}

		static public readonly Finite<T> Singleton = nilnul.obj.SingletonByDefault<Finite<T>>.Instance;

	}
}
