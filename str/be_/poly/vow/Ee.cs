using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.be_.poly.vow
{
	public class Ee<TEl>
		: nilnul.obj.str.vow.ee_.VowNeo<
			TEl
			,
			nilnul.obj.str.be_.poly.Vow<TEl>
		>
	{
		

		

		public Ee(IEnumerable<TEl> val) : base(val)
		{
		}
	}
}
