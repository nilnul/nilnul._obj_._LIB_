using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	[Obsolete()]
	public interface ConvertI1<in TArg, out TRet>
	{
		TRet convert(TArg arg);
	}
	[Obsolete()]
	public interface ConvertI1< TArg>
		:ConvertI1<TArg,TArg>
	{

	}


}
