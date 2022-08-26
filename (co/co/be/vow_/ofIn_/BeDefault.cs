﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.co.be.vow_.ofIn_
{
	public class BeDefault<T, TBe>
		:
		be.vow_.OfIn<T>
		where TBe : obj.BeI_ofIn<(T, T)>, new()
	{
		public BeDefault() : base(
			 nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}

		static public BeDefault<T, TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<BeDefault<T, TBe>>.Instance;
			}
		}



	}
}
