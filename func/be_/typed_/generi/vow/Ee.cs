﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using F = nilnul.obj.FuncI3;


namespace nilnul.obj.func.be_.typed_.generi.vow
{
	public class Ee<T> :
		nilnul.obj.vow.ee_.Defaultable<
			F,
			generi.Vow<T>
		>
	{
		public Ee(F val) : base(val)
		{
		}
		
	}
}
