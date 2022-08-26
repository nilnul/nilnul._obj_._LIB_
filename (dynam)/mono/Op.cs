using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.dynam.mono
{
	public class Op
	{
		static public TR  Eval<TOp, TR,TP>(TOp op, Dynam arg  )
			where TOp :obj.mono.OpI<TP,TR>
			{

				return op.eval((TP)arg.val);
			
			}

	}
}
