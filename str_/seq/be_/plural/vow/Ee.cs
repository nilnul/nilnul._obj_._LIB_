using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str_.seq.be_.plural.vow
{
	public class Ee<TEl>
		: nilnul.obj.str_.seq.vow.ee_.VowDefault_strGeneral<TEl, nilnul.obj.str_.seq.be_.plural.Vow<TEl>>
	{
		public Ee(SeqI2<TEl> val) : base(val)
		{
		}

		public Ee(IEnumerable<TEl> seq) : base(seq)
		{
		}
	}
}
