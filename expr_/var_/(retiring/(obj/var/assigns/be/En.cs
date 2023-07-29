using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  nilnul.obj.var.assigns.be
{
	public class En<T> : nilnul.obj.be.En<IEnumerable<Assignment<T>>, BeI<T>>
	{
		public En(IEnumerable<Assignment<T>> val, BeI<T> be) : base(val, be)
		{

		}
	}

	public class En<T, TBe> : En<T>
		where TBe : BeI<T>, new()
	{
		public En(IEnumerable<Assignment<T>> val ) : base(val, SingletonByDefault<TBe>.Instance)
		{
		}
	}
}
