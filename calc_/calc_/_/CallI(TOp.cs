using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	

	public interface CallI1<out TOp>:CallI,_call_.OpI1<TOp>
		where TOp:nilnul.obj._op_.BlankI
	{

	}
}
