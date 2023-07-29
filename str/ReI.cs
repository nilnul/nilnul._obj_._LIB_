using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str
{
	public interface Re4seqI<T>
		:
		obj.ReI<
			IEnumerable<T>
		>
		,IRe
	{
	}
}
