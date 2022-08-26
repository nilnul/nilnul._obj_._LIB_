using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.call_
{
	public interface UnaryI<TOp,TArg>:nilnul.obj.CallI1<TOp>
		where TOp: nilnul.obj.op_._unary_.BlankI
	{
	}
}
