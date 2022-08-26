using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.var.set.states.be
{
	public class En_ofDict<T>
		: nilnul.obj.be.En<IEnumerable<State_heritDict<T>>, BeI_ofDict<T>>

	{
		public En_ofDict(IEnumerable<State_heritDict<T>> val, BeI_ofDict<T> be) : base(val, be)
		{
		}
	}

	public class En_ofDict<T, TBe> : En_ofDict<T>
		where TBe : BeI_ofDict<T>, new()
	{
		public En_ofDict(IEnumerable<State_heritDict<T>> val ) : base(val, SingletonByDefault<TBe>.Instance)
		{
		}
	}
}
