﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.func.calc_.lamda_.uni.be.vow_
{
	public class BeDefault< TBe>
		:
		Vow
		where TBe : nilnul.obj.BeI1<func.calc_.lamda_.shelly_.Uni>, new()
	{
		public BeDefault() : base(nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance)
		{
		}


		static public BeDefault< TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault< TBe>>.Instance;
			}
		}

	}
}
