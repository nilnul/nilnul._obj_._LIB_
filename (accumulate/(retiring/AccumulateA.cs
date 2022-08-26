using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	
	[Obsolete()]
	public abstract class AccumulateA<T> : AccumulateI<T>
	{
		public abstract T eval(IEnumerable<T> arg);
		public T eval(params T[] arg) { return eval(arg as IEnumerable<T>); }
	}
}
