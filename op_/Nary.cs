﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op_
{
	public class Nary<T> :

		_nary_.Ret<T>
		,
		NaryI<T>
		//,
		//op_.of_.VecI<T>
	{
		public Nary(T ret) : base(ret)
		{
		}

		public int arity =>0;

		public T op(IEnumerable<T> vec)
		{
			obj.vec.of_._StrX._VowArity(0, vec);
			return op();
			//throw new NotImplementedException();
		}
	}

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// alias:
	///		nary_.ByFunc
	public class NaryOnFunc<T>
		:
		nilnul.obj.Box1<Func< T>>,

		NaryI<T>
		//,
		//op_.of_.VecI<T>
	{
		public NaryOnFunc(Func<T> val) : base(val)
		{
		}

		public int arity =>0;

		public T op()
		{
			return boxed();
			//throw new NotImplementedException();
		}

		public T op(IEnumerable<T> vec)
		{
			obj.vec.of_._StrX._VowArity(0, vec);
			return op();
			//throw new NotImplementedException();
		}
	}
}
