﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.re_.le.lt
{
	public class Not<T,  TLe> : re.Complement<T, re_.le.Lt<T,TLe>>
		where TLe: nilnul.obj.re_.LeI<T>,new()
	{


		static public Not<T,  TLe> Singleton
		{
			get
			{
				return nilnul.obj_.Singleton<Not<T, TLe>>.Instance;
			}
		}

	}
}
