﻿using nilnul.obj.of_._vec_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.of_.vec_
{
	/// <summary>
	/// of a vector. This is a n-ary operator, but we dont know the arity statically.
	/// </summary>
	public class Scala<T>
		:
		ScalaI<T>
	{
		private uint _arity;

		public int arity => (int)_arity;


		private Func<IEnumerable<T>, T> _func;
		public Scala(uint arity, Func<IEnumerable<T>,T> func)
		{
			this._arity = arity;
			this._func = func;
		}

		public Scala(int arity, Func<IEnumerable<T>,T> func):this((uint) arity, func)
		{
			
		}

		public T op(IEnumerable<T> vec)
		{
			if (vec.Count()!=_arity)
			{
				throw new ArgumentException($"{nameof(vec)}:{vec}'arity is not {this._arity}.");
			}
			return _func(vec);
		}

		static public void _VowArity(int _arity, IEnumerable<T> vec )
		{

			obj.vec.of_._StrX._VowArity(_arity, vec);
		}

	}
}
