using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.val
{
	public partial interface LiteralI<out T>
		:ValI<T>,LiteralI
	{
		T val
		{
			get;
		}
	}
}
