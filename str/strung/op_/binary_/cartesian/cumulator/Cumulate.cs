﻿using nilnul.obj.op_;
using nilnul.obj.op_.binary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.str.strung.op_.binary_.cartesian.cumulator
{

	public class Cumulate<T>
		:
		nilnul.obj.op_.binary.cumulator.cumulate_.CumulatorDefault<
			IEnumerable<IEnumerable<T>>
			,
			Cumulator<T>
		>


	{

		static public Cumulate<T> Singleton
		{
			get
			{
				return nilnul._obj.typ_.nilable_.unprimable_.Singleton<Cumulate<T>>.Instance;
			}
		}

		/// <summary>
		/// eg:
		///		( [a,b])  ([c,d]) ([e,f])
		///		= (a,c,e) ,(a,c,f),(a,d,e),(a,d,f), (b,c,e), (b,c,f) ,(b,d,e), (b,d,f)
		/// </summary>
		/// <param name="pars1"></param>
		/// <returns></returns>
		public IEnumerable<IEnumerable<T>> cumulate_each2monos(  IEnumerable<IEnumerable<T>> pars1)
		{
			return base.cumulate(
				pars1.Select(
					p=> strung.op_.of_.OfMonos<T>.Singleton.op(p)
				)
			);
		}


		public IEnumerable<IEnumerable<T>> cumulate_each2monos(params  IEnumerable<T>[] pars1)
		{
			return cumulate_each2monos((IEnumerable<IEnumerable<T>>) pars1);
			return base.cumulate(
				pars1.Select(
					p=> strung.op_.of_.OfMonos<T>.Singleton.op(p)
				)
			);
		}

	}
}
