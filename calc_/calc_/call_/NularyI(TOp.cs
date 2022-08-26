using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_
{
	public interface NularyI<out TOp>:nilnul.obj.CallI1<TOp>, NularyI
		where TOp:nilnul.obj._op_.BlankI

	{

	}
}
