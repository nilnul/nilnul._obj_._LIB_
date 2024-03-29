﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_.binary.cumulator.be_.unard_
{
	/// <summary>
	/// </summary>
	/// <see cref="binary.converse.cumulator"/>
	public class LeftUnardDefault<T,TBe>
		:
		Unard<T>
		where TBe: binary.cumulator.be_._unard.semi_.LeftUnardI<T>,new()

	{
		public LeftUnardDefault() : base(
			nilnul._obj.typ_.nilable_.unprimable_.singleton_.ByLazy<TBe>.Instance
		)
		{
		}


		static public LeftUnardDefault<T,TBe> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<LeftUnardDefault<T,TBe>>.Instance;
			}
		}




	}
}
