using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	public interface AggregateI<TStr, T>
		: nilnul.obj.OpI<TStr,T>
		where TStr:nilnul.obj.StrI<T>
	{
	}
}
