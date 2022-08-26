using nilnul.obj.be.vow_.xpN_._fail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be
{

	public class Vow1<T>
		:
		nilnul.obj.be.Vow4<
			IEnumerable<T>
		>
	{
		public Vow1(obj.BeI1<IEnumerable<T>> be) : base(be)
		{
		}

		public Vow1(Predicate<IEnumerable<T>> predicate) : base(predicate)
		{
		}

		public Vow1(Func<IEnumerable<T>, bool> func) : base(func)
		{
		}
	}

}
