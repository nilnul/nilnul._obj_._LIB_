using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{

	[Obsolete("wrong position of TRet")]
	public interface OfI<in TArg, out TRet>:
		IOf
		//,
		//nilnul.obj.iop
	{
		TRet of(TArg arg);
	}

	[Obsolete("wrong position of TRet")]
	public interface OfI<in TArg> : _of.ParGenericI<TArg, object>
	{
	}

}
