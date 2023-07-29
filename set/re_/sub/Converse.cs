using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.set.re_.sub
{
	public class Converse<T>
		: nilnul.obj.re.Converse<IEnumerable<T>>
		,
		set.ReOfEnumerable<T>
	{
		public Converse(set.re_.Sub<T> re) : base(re)
		{
		}
	}
}
