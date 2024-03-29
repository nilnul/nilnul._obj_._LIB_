﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.expr_.call_._unary
{

	[Obsolete(nameof(obj.calc_._unary.ArgI<T>))]

	public interface ArgI<out T>
	{
		T arg { get; }
	}

	[Obsolete(nameof(obj.calc_._unary.ArgI<TArg>))]
	public  class Arg< TArg> :  ArgI<TArg>
		
	{
		private TArg _arg;

		public TArg arg
		{
			get { return _arg; }
			set { _arg = value; }
		}

		public Arg(TArg arg) 
		{
			_arg = arg;
		}
	}
}
