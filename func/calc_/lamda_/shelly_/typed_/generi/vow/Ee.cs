﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.typed_.generi.vow
{
	public class Ee<TRet>
		:
		nilnul.obj.vow.Ee1<
			obj.func.calc_.lamda_.typed_.Generi<TRet>
			,
			func.calc_.lamda_.typed_.generi.VowI<TRet>
		>
	{
		public Ee(func.calc_.lamda_.typed_.Generi<TRet> val, VowI<TRet> vow) : base(val, vow)
		{
		}
	}
}
