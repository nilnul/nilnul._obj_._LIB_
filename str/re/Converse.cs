using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.re
{
	public class Converse<TEl>
		:
		nilnul.obj.re.Converse<IEnumerable<TEl>>
		,
		obj.str.Re4seqI<TEl>
	{
		public Converse(ReI<IEnumerable<TEl>> re) : base(re)
		{
		}
	}
}
