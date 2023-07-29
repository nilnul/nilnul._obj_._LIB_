using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.of_
{


	public interface OfEmptyI<out TRet>
		:IOfEmpty<TRet>
	{
		TRet op();
	}

	



}
