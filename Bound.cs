﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj
{
	public interface BoundI<TBorder>
		:BoundI<TBorder,TBorder>
	{
	}

	public class Bound<TLower, TUpper>
	{

	}

}
