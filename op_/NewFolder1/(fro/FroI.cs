using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete(nameof(nilnul.obj.op_.IOf))]
	public interface FroI<TSrc,TDst>
	{
		TDst fro(TSrc src);
	}
}
