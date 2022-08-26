using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_
{
	public class Nulary<TOp> : nilnul.obj._call_.OpA1<TOp>, nilnul.obj.call_.NularyI<TOp>
		where TOp : nilnul.obj._op_.BlankI

	{
		public Nulary(TOp op) : base(op)
		{
		}
	}
}
