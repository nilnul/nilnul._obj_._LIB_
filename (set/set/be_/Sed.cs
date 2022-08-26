using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.be_
{
	public class Sed<TElement> : BeI<TElement>
	{
		public bool be(SetI1<TElement> obj)
		{
			return obj.toArr().Any();
			//throw new NotImplementedException();
		}


		static public readonly Sed<TElement> Singleton = nilnul.obj.SingletonByDefault<Sed<TElement>>.Instance;

	}
}
