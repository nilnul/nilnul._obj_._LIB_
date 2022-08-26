using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.be
{
	public class Vow<T>
		:
		nilnul.obj.be.Vow4<
			IEnumerable<IEnumerable<T>>
		>
	{
		public Vow(obj.BeI1<IEnumerable<IEnumerable<T>>> be) : base(be)
		{
		}

		public Vow(Predicate<IEnumerable<IEnumerable<T>>> predicate) : base(predicate)
		{
		}

		public Vow(Func<IEnumerable<IEnumerable<T>>, bool> func) : base(func)
		{
		}
	}
}
