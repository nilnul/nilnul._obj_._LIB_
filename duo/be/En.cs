using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.duo.be
{
	public class En<T>
		: nilnul.obj.be.En<Tuple<T,T>>
	{
		public En(obj.BeI<Tuple<T, T>> be, Tuple<T, T> val) : base(be, val)
		{
		}
	}

	public class En<T, TBe>
		: En<T>
		where TBe:nilnul.obj.BeI<Tuple<T, T>>,new()
	{
		public En(Tuple<T, T> val) : base(SingletonByDefault<TBe>.Instance, val)
		{
		}
	}
}
