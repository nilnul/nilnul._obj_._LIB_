﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary._cumulator_
{
	public interface BinderI< out TOp>
		
	{
		TOp binder { get; }
	}


}
