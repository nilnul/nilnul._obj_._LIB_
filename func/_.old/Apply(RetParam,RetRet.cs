﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.func
{

	public partial interface ApplyI< ExprParam, ExprRet>
	{

		FuncI<ExprParam, ExprRet> apply<Arg>(
			
			expr.ExprI<Arg> arg
		);


	}
}
