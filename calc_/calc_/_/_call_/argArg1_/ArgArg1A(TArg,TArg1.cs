using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.obj._call_.argArg1_
{
	

	public abstract class ClosedA<T> : ArgArg1A<T, T>
	{
		public ClosedA(T arg, T arg1) : base(arg, arg1)
		{
		}
	}

}
