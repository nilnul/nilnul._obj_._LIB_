﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	public interface OpI3<TPar,TRet> 
		:
		OpI3<TRet>

	{
		TRet op(TPar par);

	}


}
