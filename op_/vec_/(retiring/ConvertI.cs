using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete()]
	public interface ConvertI<in TArg, out TRet>
	{
		TRet eval(TArg arg);
	}
	[Obsolete()]
	public interface ConvertI< TArg>
		:ConvertI<TArg,TArg>
	{

	}


}
