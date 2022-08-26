using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface CastI<in TIn, out TOut>
	{
		TOut cast(TIn input);
	}
}
