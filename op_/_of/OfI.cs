using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj._of
{
	/// <summary>
	/// convert src to target
	/// </summary>
	/// <typeparam name="TArg"></typeparam>
	/// <typeparam name="TRet"></typeparam>
	///
	[Obsolete("namespace shall be:" + nameof(nilnul.obj.op_/*._of*/))]
	public interface ParGenericI< in TArg, out TRet>
	{
		TRet of(TArg arg);
	}

	

}
