﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.objs_
{
	public abstract class EnumableA<T> : nilnul.objs_.EnumerableI<T>
	{


		public abstract IEnumerator<T> GetEnumerator();
		

		public T[] toArr()
		{
			return (this as IEnumerable<T>).ToArray();
			throw new NotImplementedException();
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
			throw new NotImplementedException();
		}
	}
}
