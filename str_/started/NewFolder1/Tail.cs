﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_.started
{
	[Obsolete()]
	public static  class _TailX
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="_started"></param>
		/// <returns></returns>
		/// <exception cref=""></exception>
		///
		[Obsolete()]

		static public IEnumerable<T> _Tail<T>(this IEnumerable<T> _started ) {
			return _started.Skip(1);
		}
	}
}
