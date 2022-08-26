using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.op
{
	public partial interface BiOpI<out R> : BiOpI, OpI<R>
	{
	}
}
