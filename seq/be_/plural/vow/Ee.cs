using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.seq.be_.plural.vow
{
	public class Ee<TEl>
		: nilnul.obj.seq.vow.ee_.VowDefaulted<TEl, nilnul.obj.seq.be_.plural.Vow<TEl>>
	{
		public Ee(IEnumerable<TEl> val) : base(val)
		{
		}
	}
}
